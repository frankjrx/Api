using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Platos : Auditable
    {
        public string Nombre { get; set; }
        public double precio { get; set; }
        public int CantidadPersonas { get; set; }
        public string Categoria { get; set; }
        public ICollection<PlatosIngrediente>? PlatosIngrediente { get; set; }
        public ICollection<OrdenesPlatos>? OrdenesPlatos { get; set; }



        public string? UserId { get; set; }

    }
}
