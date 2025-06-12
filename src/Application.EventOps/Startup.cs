using Application.EventOps.Interfaces;
using Application.EventOps.Services;
using Microsoft.Extensions.DependencyInjection;
namespace Application.EventOps;

public static class Startup
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        // Register AutoMapper profiles
        services.AddAutoMapper(typeof(Startup).Assembly);
        
        // Register application services
        services.AddScoped(typeof(IIncidentService), typeof(IncidentServices));
        
        return services;
    }
}
