using GR.ERP.Application.Interfaces;
using GR.ERP.Infraestrutura.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GR.ERP.Infraestrutura
{
    public static class InjecoesDependencia
    {
        public static void AddInfraestrutura(this IServiceCollection services, IConfiguration configuration)
        {
            ConfigurarPostgres(services, configuration);
            RegistrarDependencias(services);
        }

        private static void ConfigurarPostgres(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options => options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));
        }

        private static void RegistrarDependencias(this IServiceCollection services)
        {
            services.AddScoped<IApplicationDbContext>(provider => provider.GetService<ApplicationDbContext>());
        }
    }
}
