using Integrify.Shared.Abstractions.Commands;
using Integrify.Shared.Abstractions.Time;
using Integrify.Shared.Infrastructure.Commands;
using Microsoft.Extensions.DependencyInjection;

namespace Integrify.Shared.Infrastructure.Time;

public static class Extensions
{
    public static IServiceCollection AddClocks(this IServiceCollection services)
    {
        services.AddSingleton<IClock, UtcTime>();
        
        return services;
    }
}