using System.Reflection;
using Integrify.Shared.Abstractions.Events;
using Microsoft.Extensions.DependencyInjection;

namespace Integrify.Shared.Infrastructure.Events;

public static class Extensions
{
    public static IServiceCollection AddEvents(this IServiceCollection services, IEnumerable<Assembly> assemblies)
    {
        services.AddSingleton<IEventPublisher, EventPublisher>();
        services.Scan(s => s.FromAssemblies(assemblies)
            .AddClasses(c => c.AssignableTo(typeof(IEventHandler<>)))
            .AsImplementedInterfaces()
            .WithScopedLifetime());
        
        return services;
    }
}