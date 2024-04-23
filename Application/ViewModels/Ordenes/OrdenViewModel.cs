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
    public class OrdenViewModel
    {
        public int Id { get; set; }
        public int MesaId { get; set; }
        public ICollection<PlatoViewModel>? platos { get; set; }
        public ICollection<MesaViewModel>? Mesa { get; set; }
        public double Subtotal { get; set; }
        public string Estado { get; set; }


    }
}
