using Application.ViewModels.Mesa;
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
    public interface IMesaServices : IGenericServices<Mesas, MesaViewModel, SaveMesaViwModel>
    {
    }
}
