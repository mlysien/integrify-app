using Integrify.Integrations.Customers.Port.Driving;
using Integrify.Integrations.Customers.Port.Models;

namespace Integrify.Plugins.ShopSimulator.Customers.Adapter.Driving;

public class CustomersShopSimulatorDrivingAdapter : ICustomersIntegrationDrivingPort
{
    public async Task<IReadOnlyCollection<CustomerModel>> GetCustomersCollectionAsync()
    {
        return await Task.Run(() => new List<CustomerModel>()
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

    public async Task<CustomerModel> GetSingleCustomerAsync(Guid id)
    {
        return await Task.Run(() => new CustomerModel()
        {
            Id = Guid.NewGuid(),
            IsActive = true,
            Name = "Aleksander Surdel"
        });
    }
}