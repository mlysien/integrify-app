using System.Reflection;
using Integrify.Shared.Abstractions.Commands;
using Integrify.Shared.Abstractions.Queries;
using Integrify.Shared.Infrastructure.Commands;
using Microsoft.Extensions.DependencyInjection;

namespace Integrify.Shared.Infrastructure.Queries;

public static class Extensions
{
    /// <summary>
    /// Adding all services required for query dependencies 
    /// </summary>
    /// <param name="services">Default IServiceCollection register</param>
    /// <param name="assemblies">List of assemblies for register all IQueryHandler classes</param>
    public static IServiceCollection AddQueries(this IServiceCollection services, IEnumerable<Assembly> assemblies)
    {
        services.AddSingleton<IQueryDispatcher, QueryDispatcher>();
        services.Scan(s => s.FromAssemblies(assemblies)
            .AddClasses(c => c.AssignableTo(typeof(IQueryHandler<,>)))
            .AsImplementedInterfaces()
            .WithScopedLifetime());
        
        return services;
    }
}