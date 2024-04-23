using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public  class Mesas : Auditable
    {
        public int CantidadPersonas { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }


        public ICollection<OrdenMesa>? OrdenMesa { get; set; }

        public string? UserId { get; set; }
    }
}
