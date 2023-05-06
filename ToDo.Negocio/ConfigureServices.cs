using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Datos.Interfases;
using ToDo.Datos.Repositorios;
using ToDo.Negocio.Tareas.Implementacion;
using ToDo.Negocio.Tareas.Interfaz;

namespace Todo.Negocio
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<ITareaNegocio, TareaNegocio>();
            return services;
        }
    }
}