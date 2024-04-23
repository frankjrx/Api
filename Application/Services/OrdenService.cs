using Application.Dto.User;
using Application.Helpers;
using Application.Interfacez.IRepositorios;
using Application.Interfacez.IServices;
using Application.ViewModels.Ingredientes;
using Application.ViewModels.Ordenes;
using Application.ViewModels.Platos;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class OrdenService : GenericService<Ordenes, OrdenViewModel, SaveOrdenViewModel>, IOrdenServices
    {
        private readonly IOrdenRepository _ordenRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IMapper _mapper;
        private readonly AuthenticationResponse userViewModel;
        public OrdenService(IOrdenRepository repository, IMapper mapper, IHttpContextAccessor httpContextAccessor) : base(repository, mapper)
        {
            _ordenRepository = repository;
            _httpContextAccessor = httpContextAccessor;
            _mapper = mapper;
            userViewModel = _httpContextAccessor.HttpContext.Session.Get<AuthenticationResponse>("user");
        }

        public async Task<List<OrdenViewModel>> GetAllViewModelWithInclude()
        {
            var OrdenList = await _ordenRepository.GetAllWithIncludeAsync(new List<string> { "OrdenesPlatos" });


            return OrdenList.Select(orden => new OrdenViewModel
            {
                MesaId = orden.MesaId,
                //mesa = orden.mesa,
                Id = orden.Id,
                Estado = orden.Estado,
                Subtotal = orden.Subtotal,
                platos = orden.OrdenesPlatos.Select(pi => new PlatoViewModel
                {
                    Id = pi.Plato.Id,
                    Nombre = pi.Plato.Nombre,
                    CantidadPersonas = pi.Plato.CantidadPersonas,
                    precio = pi.Plato.precio,
                    Categoria = pi.Plato.Categoria,
                    ingredientes = pi.Plato.PlatosIngrediente.Select(pi => new IngredienteViewModel
                    {
                        Id = pi.Ingrediente.Id,
                        Nombre = pi.Ingrediente.Nombre,
                    }).ToList()
                }).ToList()
            }).ToList();
        }
    }
}
