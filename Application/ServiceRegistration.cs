using Application.Interfacez.IServices;
using Application.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public static class ServiceRegistration
    {
        public static void AddApplicationLayer(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            //services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
            #region Services
            services.AddTransient(typeof(IGenericServices<,,>), typeof(GenericService<,,>));
            services.AddTransient<IMesaServices, MesaServices>();
            services.AddTransient<IOrdenServices, OrdenService>();
            services.AddTransient<IingredienteServices, IngredienteServices>();
            services.AddTransient<IPlatoServices, PlatoService>();
            services.AddTransient<IUserService, UserService>();
            #endregion
        }
    }
}
