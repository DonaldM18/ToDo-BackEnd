using System.Text.Json.Serialization;

namespace ToDo.WebAPI.Modules.Features
{
    public static class FeatureExtension
    {
        public static IServiceCollection AddFeature(this IServiceCollection services, IConfiguration configuration)
        {
            string myPolicy = "policyApiTodo";



            services.AddCors(options => options.AddPolicy(myPolicy, builder => builder.WithOrigins(configuration["Config:OriginCors"])
            .AllowAnyHeader()
            .AllowAnyMethod()
            .AllowAnyOrigin()));
            services.AddMvc();
            services.AddControllers().AddJsonOptions(opts =>
            {
                var enumConverter = new JsonStringEnumConverter();
                opts.JsonSerializerOptions.Converters.Add(enumConverter);
            });



            return services;

        }
    }
}
