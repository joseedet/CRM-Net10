using CRM.Infraestructura.Persistencia.Contextos;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CRM.Infraestructura;

public static class DependencyInjection
{
    public static IServiceCollection AddInfraestructura(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        var cadenaConexion =
            configuration.GetConnectionString("DefaultConnection")
            ?? throw new InvalidOperationException(
                "No existe la cadena de conexión.");

        services.AddDbContext<ApplicationDbContext>(options =>
        {
            options.UseNpgsql(cadenaConexion);
        });

        return services;
    }
}
