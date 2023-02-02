using Application.Interfaces;

namespace Infrastructure.DependencyResolver;
using Microsoft.Extensions.DependencyInjection;

public class DependencyResolver
{
    public static void RegisterInfrastructureLayer(IServiceCollection service)
    {
        service.AddScoped<IFactionRepository, FactionRepository>();
    }
}