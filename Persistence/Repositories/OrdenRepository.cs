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
    public class OrdenRepository : GenericRepository<Ordenes>, IOrdenRepository
    {
        public OrdenRepository(ApplicationContext dbContext) : base(dbContext)
        {
        }
    }
}
