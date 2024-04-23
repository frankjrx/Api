using Application.Interfacez.IRepositorios;
using Application.Interfacez.IServices;
using Application.ViewModels.Mesa;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class MesaServices : GenericService<Mesas, MesaViewModel, SaveMesaViwModel>, IMesaServices
    {

        public MesaServices(IGenericRepository<Mesas> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
