using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ToDo.Datos.Context;
using ToDo.Datos.Interfases;
using ToDo.Datos.Repositorios;

namespace Todo.Datos
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<DapperContext>();
            services.AddScoped<ITareasRepositorio, TareasRepositorio>();
            return services;
        }
    }
}