using System.Reflection;
using Integrify.Shared.Abstractions.Commands;
using Integrify.Shared.Abstractions.Integrations;
using Integrify.Shared.Infrastructure.Commands;
using Microsoft.Extensions.DependencyInjection;

namespace Integrify.Shared.Infrastructure.Integrations;

public static class Extensions
{
    /// <summary>
    /// Adding all services required for command dependencies 
    /// </summary>
    /// <param name="services">Default IServiceCollection register</param>
    /// <param name="assemblies">List of assemblies for register all ICommandsHandler classes</param>
    public static IServiceCollection AddIntegrations(this IServiceCollection services, IEnumerable<Assembly> assemblies)
    {
        services.AddSingleton<IIntegrationDispatcher, IntegrationDispatcher>();
        services.Scan(s => s.FromAssemblies(assemblies)
            .AddClasses(c => c.AssignableTo(typeof(IIntegrationHandler<>)))
            .AsImplementedInterfaces()
            .WithScopedLifetime());
        
        return services;
    }
}