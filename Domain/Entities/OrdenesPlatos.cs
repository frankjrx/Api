using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class OrdenesPlatos 
    {
        public int OrdenId { get; set; }
        public Ordenes Orden { get; set; }

        public int PlatoId { get; set; }
        public Platos Plato { get; set; }
    }
}
