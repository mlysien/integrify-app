using Integrify.Integrations.Products.Api.Services;
using Integrify.Integrations.Products.Core;
using Integrify.Shared.Abstractions.Integrations;
using Microsoft.Extensions.DependencyInjection;

namespace Integrify.Integrations.Products.Api;

internal sealed class ProductsIntegration : IIntegration
{
    public string Name => "Products";
    
    public void AddIntegrationDependencies(IServiceCollection serviceCollection)
    {
        serviceCollection.AddProductsIntegrationApi();
        serviceCollection.AddIntegrationCoreLayer();
    }
}