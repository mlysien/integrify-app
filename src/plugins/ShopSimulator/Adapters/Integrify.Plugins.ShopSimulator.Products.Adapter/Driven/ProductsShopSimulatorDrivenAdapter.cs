using Integrify.Integrations.Products.Model;
using Integrify.Integrations.Products.Port.Driven;
using Integrify.Plugins.ShopSimulator.Domain.Models;
using Integrify.Plugins.ShopSimulator.Domain.Repositories.Abstractions;
using Integrify.Shared.Abstractions.Time;

namespace Integrify.Plugins.ShopSimulator.Products.Adapter.Driven;

internal sealed class ProductsShopSimulatorDrivenAdapter(
    IClock clock,
    IProductRepository repository) : IProductsIntegrationDrivenPort
{
    public async Task PushAsync(ProductIntegrationModel integrationModel)
    {
        var product = new Product()
        {
            Id = integrationModel.Id.Value,
            Name = integrationModel.Name,
            Price = integrationModel.Price,
            Tax = integrationModel.TaxRate,
            LastUpdated = clock.NowDateTime()
        };

        await repository.SaveProductAsync(product);
    }
}