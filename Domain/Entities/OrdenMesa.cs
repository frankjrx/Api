using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class OrdenMesa
    {

        public int OrdenId { get; set; }
        public Ordenes Orden { get; set; }

        public int MesaId { get; set; }
        public Mesas Mesa { get; set; }
    }
}
