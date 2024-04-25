using System.Reflection;
using Integrify.Shared.Abstractions.Synchronizations;
using Microsoft.Extensions.DependencyInjection;

namespace Integrify.Shared.Infrastructure.Synchronizations;

public static class Extensions
{
    /// <summary>
    /// Adding all services required for sychronizations dependencies 
    /// </summary>
    /// <param name="services">Default IServiceCollection register</param>
    /// <param name="assemblies">List of assemblies for register all ISynchronizationHandler classes</param>
    public static void AddSynchronizations(this IServiceCollection services, IEnumerable<Assembly> assemblies)
    {
        services.AddSingleton<ISynchronizationDispatcher, SynchronizationDispatcher>();
        services.Scan(s => s.FromAssemblies(assemblies)
            .AddClasses(c => c.AssignableTo(typeof(ISynchronizationHandler<>)))
            .AsImplementedInterfaces()
            .WithScopedLifetime());
    }
}