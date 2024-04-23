using Application.ViewModels.Mesa;
using Application.ViewModels.Platos;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModels.Ordenes
{
    public class SaveOrdenViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Debe colocar la mesa de la orden")]
        public int MesaId { get; set; }
        //public Mesas? mesa { get; set; }
        
        [Required(ErrorMessage = "Debe colocar el subtotal de la orden")]
        public double Subtotal { get; set; }


        public ICollection<int>? PlatosId { get; set; }

        public string Estado { get; set; }
        //public ICollection<MesaViewModel>? Mesa { get; set; }


    }
}
