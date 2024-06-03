using Integrify.Shared.Abstractions.Initializer;
using Microsoft.Extensions.DependencyInjection;

namespace Integrify.Shared.Infrastructure.Initializer;

public static class Extensions
{
    public static void AddInitializer(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddSingleton<IInitializer, Initializer>();
    }
}