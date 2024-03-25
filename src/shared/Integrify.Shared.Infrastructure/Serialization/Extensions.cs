using Microsoft.Extensions.DependencyInjection;

namespace Integrify.Shared.Infrastructure.Serialization;

public static class Extensions
{
    public static IServiceCollection AddSerialization(this IServiceCollection services)
    {
        services.AddSingleton<IJsonSerializer, SystemTextJsonSerializer>();
        
        return services;
    }
}

