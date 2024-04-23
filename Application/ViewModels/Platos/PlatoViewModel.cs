using Application.ViewModels.Ingredientes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModels.Platos
{
    public class PlatoViewModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public double precio { get; set; }
        public int CantidadPersonas { get; set; }

        public string Categoria { get; set; }
        public ICollection<IngredienteViewModel>? ingredientes { get; set; }
    }
}
