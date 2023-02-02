using Application.Interfaces;
using Infrastructure.Interfaces;

namespace Infrastructure.DependencyResolver;
using Microsoft.Extensions.DependencyInjection;

public class DependencyResolver
{
    public static void RegisterInfrastructureLayer(IServiceCollection service)
    {
        service.AddScoped<IFactionRepository, FactionRepository>();
        service.AddScoped<IDatabaseRepository, DatabaseRepository>();
    }
}