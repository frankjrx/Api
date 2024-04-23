using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfacez.IServices
{
    public interface IGenericServices<Model, ViewModel, SaveViewModel>
        where Model : class
        where ViewModel : class
        where SaveViewModel : class
    {
        Task<SaveViewModel> Add(SaveViewModel vm);
        Task Update(int id, SaveViewModel vm);
        Task Delete(int id);
        Task<List<ViewModel>> GetAll();

        Task<SaveViewModel> GetById(int id);
    }
}
