using Infrastructure.EventOps.Database;
using Infrastructure.EventOps.Entities;
using Infrastructure.EventOps.Interfaces;
using Infrastructure.EventOps.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
namespace Infrastructure.EventOps;

public static class Startup
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, string connectionString)
    {
        // Register DbContext
        services.AddDbContext<EventOpsContext>(options =>
            options.UseNpgsql(connectionString));
        
        // Register repositories
        services.AddScoped(typeof(IRepository<Incident>), typeof(Repository<Incident>));
        services.AddScoped(typeof(IRepository<Role>), typeof(Repository<Role>));
        services.AddScoped(typeof(IRepository<User>), typeof(Repository<User>));
        
        return services;
    }
}
