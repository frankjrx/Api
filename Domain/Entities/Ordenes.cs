using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Ordenes : Auditable
    {
        public int MesaId { get; set; }
        public Mesas? mesa { get; set; }
        
        public double Subtotal { get; set; }
        public string Estado { get; set; }


        public ICollection<OrdenesPlatos>? OrdenesPlatos { get; set; }
        public ICollection<OrdenMesa>? OrdenMesa { get; set; }



        public string? UserId { get; set; }

    }
}
