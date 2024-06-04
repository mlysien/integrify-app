using Integrify.Integrations.Products.Model;
using Integrify.Integrations.Products.Port.Driving;
using Integrify.Plugins.ErpSimulator.Domain.Repositories.Abstractions;
using Integrify.Shared.Abstractions.ValueObjects;

namespace Integrify.Plugins.ErpSimulator.Products.Adapter.Driving;

internal sealed class ProductsErpSimulatorDrivingAdapter(IProductRepository repository) : IProductsIntegrationDrivingPort
{
    public async Task<IReadOnlyCollection<ProductIntegrationModel>> FetchCollectionAsync(IntegrationTimestamp timestamp)
    {
        var integrationModelProducts = new List<ProductIntegrationModel>();
        var products = await repository.GetProductsAsync();
        
        foreach (var product in products)
        {
            if (product.LastUpdated.Ticks >= timestamp.Ticks)
            {
                integrationModelProducts.Add(new ProductIntegrationModel()
                {
                    Id = new IntegrationId(product.Id),
                    Name = product.Name,
                    Category = product.Category,
                    Price = product.Price,
                    TaxRate = product.Tax
                });
            }
        }

        return integrationModelProducts;
    }

    public async Task<ProductIntegrationModel> GetSingleAsync(IntegrationId id)
    {
        var product = await repository.GetProductAsync(id.Value);

        return new ProductIntegrationModel()
        {
            Id = id,
            Name = product.Name,
            Price = product.Price,
            TaxRate = product.Tax,
            Category = product.Category
        };
    }
}