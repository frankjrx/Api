using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModels.Mesa
{
    public class SaveMesaViwModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Debe colocar la cantidad de personas que necesita la mesa")]
        public int CantidadPersonas { get; set; }
        [Required(ErrorMessage = "Debe colocar el nombre del producto")]
        public string Descripcion { get; set; }
        public string Estado { get; set; }


    }
}
