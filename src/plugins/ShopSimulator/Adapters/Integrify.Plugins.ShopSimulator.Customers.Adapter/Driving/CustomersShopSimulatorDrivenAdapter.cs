using Integrify.Integrations.Customers.Model;
using Integrify.Integrations.Customers.Model.Enums;
using Integrify.Integrations.Customers.Port.Driving;
using Integrify.Plugins.ShopSimulator.Domain.Repositories.Abstractions;
using Integrify.Shared.Abstractions.ValueObjects;

namespace Integrify.Plugins.ShopSimulator.Customers.Adapter.Driving;

internal sealed class CustomersShopSimulatorDrivingAdapter(ICustomerRepository repository) : ICustomersIntegrationDrivingPort
{
    public async Task<IReadOnlyCollection<CustomerIntegrationModel>> FetchCollectionAsync(
        IntegrationTimestamp timestamp)
    {
        var models = new List<CustomerIntegrationModel>();
        var customersList = await repository.GetCustomersAsync();

        foreach (var customer in customersList)
        {
            if (customer.LastUpdated.Ticks >= timestamp.Ticks)
            {
                models.Add(new CustomerIntegrationModel()
                {
                    Id = new IntegrationId(customer.Id),
                    Name = customer.Name,
                    IsActive = customer.AccountActivated,
                    CustomerType = customer.IsB2B ? CustomerType.B2B : CustomerType.B2C
                });
            }
        }

        return models;
    }

    public async Task<CustomerIntegrationModel> GetSingleAsync(IntegrationId id)
    {
        var customer = await repository.GetCustomerAsync(id.Value);

        return new CustomerIntegrationModel()
        {
            Id = id,
            Name = customer.Name,
            IsActive = customer.AccountActivated,
            CustomerType = customer.IsB2B ? CustomerType.B2B : CustomerType.B2C
        };
    }
}