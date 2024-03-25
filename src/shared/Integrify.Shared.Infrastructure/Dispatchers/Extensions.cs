using Integrify.Shared.Abstractions.Dispatchers;
using Microsoft.Extensions.DependencyInjection;

namespace Integrify.Shared.Infrastructure.Dispatchers;

public static class Extensions
{
    public static IServiceCollection AddDispatchers(this IServiceCollection services)
    {
        services.AddSingleton<IDispatcher, DefaultDispatcher>();

        return services;
    }
}