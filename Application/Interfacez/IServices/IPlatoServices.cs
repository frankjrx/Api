using Application.ViewModels.Mesa;
using Application.ViewModels.Platos;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfacez.IServices
{
    public interface IPlatoServices : IGenericServices<Platos, PlatoViewModel, SavePlatoViewModel>
    {
        Task<List<PlatoViewModel>> GetAllViewModelWithInclude();
    }
}
