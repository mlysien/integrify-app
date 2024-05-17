using Integrify.Integrations.Products.Port.Driving;
using Integrify.Integrations.Products.Port.Models;

namespace Integrify.Plugins.ErpSimulator.Products.Adapter.Driving;

public class ProductsErpSimulatorDrivingAdapter : IProductsIntegrationDrivingPort
{
    public async Task<IReadOnlyCollection<ProductModel>> GetProductsCollectionAsync()
    {
        return await Task.Run(() => new List<ProductModel>()
            {
                new()
                {
                    Id = Guid.NewGuid(),
                    Name = "Windows10 Home Edition",
                    Price = 100.0
                },
                new()
                {
                    Id = Guid.NewGuid(),
                    Name = "Apple iPhoneX",
                    Price = 450.25
                }
            }
        );
    }

    public Task<ProductModel> GetSingleProductAsync(Guid id)
    {
        return Task.Run(() => new ProductModel()
        {
            Id = Guid.NewGuid(),
            Name = "Windows10 Home Edition",
            Price = 100.0
        });
    }
}