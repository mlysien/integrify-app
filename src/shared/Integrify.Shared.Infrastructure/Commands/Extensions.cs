using System.Reflection;
using Integrify.Shared.Abstractions.Commands;
using Microsoft.Extensions.DependencyInjection;

namespace Integrify.Shared.Infrastructure.Commands;

public static class Extensions
{
    /// <summary>
    /// Adding all services required for command dependencies 
    /// </summary>
    /// <param name="services">Default IServiceCollection register</param>
    /// <param name="assemblies">List of assemblies for register all ICommandsHandler classes</param>
    public static IServiceCollection AddCommands(this IServiceCollection services, IEnumerable<Assembly> assemblies)
    {
        services.AddSingleton<ICommandDispatcher, CommandDispatcher>();
        services.Scan(s => s.FromAssemblies(assemblies)
            .AddClasses(c => c.AssignableTo(typeof(ICommandHandler<>)))
            .AsImplementedInterfaces()
            .WithScopedLifetime());
        
        return services;
    }
}