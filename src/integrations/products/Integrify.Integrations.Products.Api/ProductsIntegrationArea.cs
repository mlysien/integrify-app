using Integrify.Integrations.Products.Api.Public;
using Integrify.Integrations.Products.Core;
using Integrify.Shared.Abstractions.Integrations;
using Microsoft.Extensions.DependencyInjection;

namespace Integrify.Integrations.Products.Api;

internal sealed class ProductsIntegrationArea : IIntegrationArea
{
    public string Name => "Products";
    
    public void AddIntegrationDependencies(IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<IProductsIntegrationApi, ProductsIntegrationApi>();
        serviceCollection.AddIntegrationCoreLayer();
    }
}