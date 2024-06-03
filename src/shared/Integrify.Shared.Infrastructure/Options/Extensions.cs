using Integrify.Shared.Abstractions.Options;
using Microsoft.Extensions.DependencyInjection;

namespace Integrify.Shared.Infrastructure.Options;

public static class Extensions
{
    public static void AddIntegrationOptionsProvider(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddSingleton<IIntegrationOptionsProvider, IntegrationOptionsProvider>();
    }
}