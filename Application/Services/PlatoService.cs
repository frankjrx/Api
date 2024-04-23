using Application.Dto.User;
using Application.Interfacez.IRepositorios;
using Application.Interfacez.IServices;
using Application.ViewModels.Ordenes;
using Application.ViewModels.Platos;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Application.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.ViewModels.Ingredientes;
using Microsoft.EntityFrameworkCore;

namespace Application.Services
{
    public class PlatoService : GenericService<Platos, PlatoViewModel, SavePlatoViewModel>, IPlatoServices
    {
        private readonly IPlatoRepository _platoRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IMapper _mapper;
        private readonly AuthenticationResponse userViewModel;

        public PlatoService(IPlatoRepository repository, IMapper mapper, IHttpContextAccessor httpContextAccessor) : base(repository, mapper)
        {
            _platoRepository = repository;
            _httpContextAccessor = httpContextAccessor;
            _mapper = mapper;
            userViewModel = _httpContextAccessor.HttpContext.Session.Get<AuthenticationResponse>("user");
        }

        

        public async Task<List<PlatoViewModel>> GetAllViewModelWithInclude()
        {
            var PlatoList = await _platoRepository.GetAllWithIncludeAsync(new List<string> { "PlatosIngrediente.Ingrediente" });


            return PlatoList.Select(plato => new PlatoViewModel
            {
                Nombre = plato.Nombre,
                precio = plato.precio,
                Id = plato.Id,
                Categoria = plato.Categoria,
                CantidadPersonas = plato.CantidadPersonas,
                ingredientes = plato.PlatosIngrediente
                    .Where(pi => pi.Ingrediente != null) // Verificar que Ingrediente no sea nulo
                    .Select(pi => new IngredienteViewModel
                    {
                        Id = pi.Ingrediente.Id,
                        Nombre = pi.Ingrediente.Nombre,
                    }).ToList()
            }).ToList();
        }


    }
}
