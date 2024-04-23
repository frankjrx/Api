using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModels.Mesa
{
    public class MesaViewModel
    {
        public int Id { get; set; }

        public int CantidadPersonas { get; set; }

        public string Descripcion { get; set; }

        public string Estado { get; set; }

        
    }
}
