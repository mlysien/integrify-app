using Integrify.Integrations.Customers.Api.Public;
using Microsoft.Extensions.DependencyInjection;

namespace Integrify.Integrations.Customers.Api.Services;

internal static class Extensions
{
    public static void AddIntegrationApi(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<ICustomersIntegrationApi, CustomerIntegrationApi>();
    }
}