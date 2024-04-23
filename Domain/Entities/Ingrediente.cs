using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Ingrediente : Auditable
    {
        public string Nombre { get; set; }
        public ICollection<PlatosIngrediente> PlatosIngrediente { get; set; }


        public string? UserId { get; set; }
    }
}
