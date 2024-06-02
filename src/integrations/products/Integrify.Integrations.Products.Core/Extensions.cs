using Integrify.Integrations.Products.Core.Abstractions;
using Integrify.Integrations.Products.Core.Process;
using Integrify.Integrations.Products.Core.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace Integrify.Integrations.Products.Core;

public static class Extensions
{
    public static void AddIntegrationCoreLayer(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<IProductsIntegrationProcess, ProductsIntegrationProcess>();
        serviceCollection.AddScoped<IProductsIntegrationRepository, ProductsIntegrationRepository>();
    }
}