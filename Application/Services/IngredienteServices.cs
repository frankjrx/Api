using Application.Interfacez.IRepositorios;
using Application.Interfacez.IServices;
using Application.ViewModels.Ingredientes;
using AutoMapper;
using Domain.Entities;

namespace Application.Services
{
    public class IngredienteServices : GenericService<Ingrediente, IngredienteViewModel, SaveIngredienteViewModel>, IingredienteServices
    {
        public IngredienteServices(IGenericRepository<Ingrediente> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
