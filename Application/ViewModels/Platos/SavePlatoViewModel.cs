using Application.ViewModels.Ingredientes;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModels.Platos
{
    public class SavePlatoViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Debe colocar el nombre del plato")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Debe colocar el precio del plato")]
        public double precio { get; set; }
        [Required(ErrorMessage = "Debe colocar la cantidad de personas de del plato")]
        public int CantidadPersonas { get; set; }

        [Required(ErrorMessage = "Debe colocar la categoria del plato")]
        public string Categoria { get; set; }
        public ICollection<IngredienteViewModel>? ingredientes { get; set; }
    }
}
