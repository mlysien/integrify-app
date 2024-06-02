using Integrify.Integrations.Products.Model;
using Integrify.Integrations.Products.Port.Driving;
using Integrify.Shared.Abstractions.ValueObjects;

namespace Integrify.Plugins.ErpSimulator.Products.Adapter.Driving;

internal sealed class ProductsErpSimulatorDrivingAdapter : IProductsIntegrationDrivingPort
{
    public async Task<IReadOnlyCollection<ProductIntegrationModel>> FetchCollectionAsync(IntegrationTimestamp timestamp)
    {
        return await Task.Run(() => new List<ProductIntegrationModel>()
            {
                new()
                {
                    Id = new IntegrationId(Guid.NewGuid()),
                    Name = "Windows10 Home Edition",
                    Price = 100.0
                },
                new()
                {
                    Id = new IntegrationId(Guid.NewGuid()),
                    Name = "Apple iPhoneX",
                    Price = 450.25
                }
            }
        );
    }

    public async Task<ProductIntegrationModel> GetSingleAsync(IntegrationId id)
    {
        return await Task.Run(() => new ProductIntegrationModel()
        {
            Id = new IntegrationId(Guid.NewGuid()),
            Name = "Windows10 Home Edition",
            Price = 100.0
        });
    }
}