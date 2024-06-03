using Integrify.Shared.Abstractions.Integrations;
using Microsoft.Extensions.DependencyInjection;

namespace Integrify.Shared.Infrastructure.Repository;

public static class Extensions
{
    public static void AddIntegrationRepository(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddSingleton<IIntegrationRepository, IntegrationRepository>();
    }
}