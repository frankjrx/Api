using Application.Interfacez.IRepositorios;
using Domain.Entities;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class MesaRepository : GenericRepository<Mesas>, IMesaRepository
    {
        public MesaRepository(ApplicationContext dbContext) : base(dbContext)
        {
        }
    }
}
