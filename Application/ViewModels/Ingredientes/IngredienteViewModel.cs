using Application.ViewModels.Platos;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModels.Ingredientes
{
    public class IngredienteViewModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        //public ICollection<PlatoViewModel>? Platos { get; set; }
    }
}
