using Integrify.Integrations.Products.Core.Abstractions;
using Integrify.Integrations.Products.Core.Process;
using Microsoft.Extensions.DependencyInjection;

namespace Integrify.Integrations.Products.Core;

public static class Extensions
{
    public static void AddIntegrationCoreLayer(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<IProductsIntegrationProcess, ProductsIntegrationProcess>();
    }
}