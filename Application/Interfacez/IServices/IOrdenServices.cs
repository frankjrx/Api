using Application.ViewModels.Ordenes;
using Application.ViewModels.Platos;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfacez.IServices
{
    public interface IOrdenServices : IGenericServices<Ordenes, OrdenViewModel, SaveOrdenViewModel>
    {
        Task<List<OrdenViewModel>> GetAllViewModelWithInclude();
    }
}
