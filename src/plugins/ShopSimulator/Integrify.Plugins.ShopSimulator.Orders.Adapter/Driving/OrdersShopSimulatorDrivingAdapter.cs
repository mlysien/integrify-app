using Integrify.Integrations.Orders.Port.Driving;
using Integrify.Integrations.Orders.Port.Models;

namespace Integrify.Plugins.ShopSimulator.Orders.Adapter.Driving;

internal sealed class OrdersShopSimulatorDrivingAdapter : IOrdersIntegrationDrivingPort
{
    public async Task<IReadOnlyCollection<OrderIntegrationModel>> FetchCollectionAsync()
    {
        return await Task.Run(() => new List<OrderIntegrationModel>()
        {
            new()
            {
                Id = Guid.NewGuid(),
                CreatedAt = DateTime.Now.AddDays(-2)
            },
            new()
            {
                Id = Guid.NewGuid(),
                CreatedAt = DateTime.Now.AddDays(-1)
            },
            new()
            {
                Id = Guid.NewGuid(),
                CreatedAt = DateTime.Now.AddDays(-4)
            },
            new()
            {
                Id = Guid.NewGuid(),
                CreatedAt = DateTime.Now.AddHours(-4)
            }
        });
    }

    public async Task<OrderIntegrationModel> GetSingleAsync(Guid id)
    {
        return await Task.Run(() => new OrderIntegrationModel
        {
            Id = Guid.NewGuid(),
            CreatedAt = DateTime.Now.AddDays(-2)   
        });
    }
}