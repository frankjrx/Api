using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class PlatosIngrediente 
    {
        public int PlatoId { get; set; }
        public Platos Plato { get; set; }

        public int IngredienteId { get; set; }
        public Ingrediente Ingrediente { get; set; }
    }
}
