using Application.ViewModels.Ingredientes;
using Application.ViewModels.Platos;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfacez.IServices
{
    public interface IingredienteServices : IGenericServices<Ingrediente, IngredienteViewModel, SaveIngredienteViewModel>
    {
    }
}
