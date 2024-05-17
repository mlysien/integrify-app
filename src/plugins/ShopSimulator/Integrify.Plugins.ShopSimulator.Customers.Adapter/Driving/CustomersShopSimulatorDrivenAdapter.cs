using Integrify.Integrations.Customers.Port.Driving;
using Integrify.Integrations.Customers.Port.Models;

namespace Integrify.Plugins.ShopSimulator.Customers.Adapter.Driving;

public class CustomersShopSimulatorDrivingAdapter : ICustomersIntegrationDrivingPort
{
    public async Task<IReadOnlyCollection<CustomerIntegrationModel>> GetCustomersCollectionAsync()
    {
        return await Task.Run(() => new List<CustomerIntegrationModel>()
        {
            new()
            {
                Id = Guid.NewGuid(),
                IsActive = true,
                Name = "Ludwika Misiek"
            },
            new()
            {
                Id = Guid.NewGuid(),
                IsActive = false,
                Name = "Andrzej Zyzik"
            },
            new()
            {
                Id = Guid.NewGuid(),
                IsActive = true,
                Name = "Aleksander Surdel"
            }
        });
    }

    public async Task<CustomerIntegrationModel> GetSingleCustomerAsync(Guid id)
    {
        return await Task.Run(() => new CustomerIntegrationModel()
        {
            Id = Guid.NewGuid(),
            IsActive = true,
            Name = "Aleksander Surdel"
        });
    }
}