using Application.Interfacez.IRepositorios;
using Application.Interfacez.IServices;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class GenericService<Model, ViewModel, SaveViewModel> : IGenericServices<Model, ViewModel, SaveViewModel>
        where Model : class
        where ViewModel : class
        where SaveViewModel : class
    {

        public IGenericRepository<Model> _repository;
        public IMapper _mapper;
        public GenericService(IGenericRepository<Model> repository, IMapper mapper) 
        {
            _repository = repository;
            _mapper = mapper;
        }
        public virtual async Task<SaveViewModel> Add(SaveViewModel vm)
        {
            Model model = _mapper.Map<Model>(vm);
            model = await _repository.AddAsync(model);
            SaveViewModel savevm = _mapper.Map<SaveViewModel>(model);
            return savevm;
        }

        public async Task Delete(int id)
        {
            Model model = await _repository.GetById(id);
            await _repository.DeleteAsync(model);
        }

        public async Task<List<ViewModel>> GetAll()
        {
            var modelList = await _repository.GetAllAsync();
            return _mapper.Map<List<ViewModel>>(modelList);
        }

        public async Task<SaveViewModel> GetById(int id)
        {
            Model model = await _repository.GetById(id);
            SaveViewModel savevm = _mapper.Map<SaveViewModel>(model);
            return savevm;
        }

        public async Task Update(int id, SaveViewModel vm)
        {
            Model model = _mapper.Map<Model>(vm);
            await _repository.UpdateAsync(id, model);

        }
    }
}
