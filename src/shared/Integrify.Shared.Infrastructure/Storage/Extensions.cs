using Integrify.Shared.Abstractions.Storage;
using Microsoft.Extensions.DependencyInjection;

namespace Integrify.Shared.Infrastructure.Storage;


public static class Extensions
{
    public static IServiceCollection AddRequestStorage(this IServiceCollection services)
    {
        services.AddSingleton<IRequestStorage, RequestStorage>();
        
        return services;
    }
}