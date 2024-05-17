using Integrify.Integrations.Products.Port.Driving;
using Integrify.Integrations.Products.Port.Models;

namespace Integrify.Plugins.ErpSimulator.Products.Adapter.Driving;

public class ProductsErpSimulatorDrivingAdapter : IProductsIntegrationDrivingPort
{
    public async Task<IReadOnlyCollection<ProductIntegrationModel>> FetchCollectionAsync()
    {
        return await Task.Run(() => new List<ProductIntegrationModel>()
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

    public async Task<ProductIntegrationModel> GetSingleAsync(Guid id)
    {
        return await Task.Run(() => new ProductIntegrationModel()
        {
            Id = Guid.NewGuid(),
            Name = "Windows10 Home Edition",
            Price = 100.0
        });
    }
}