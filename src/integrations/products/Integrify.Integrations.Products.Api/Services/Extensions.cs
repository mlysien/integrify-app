using Integrify.Integrations.Products.Api.Public;
using Microsoft.Extensions.DependencyInjection;

namespace Integrify.Integrations.Products.Api.Services;

internal static class Extensions
{
    public static void AddProductsIntegrationApi(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<IProductsIntegrationApi, ProductsIntegrationApi>();
    }
}