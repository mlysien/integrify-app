using Integrify.Integrations.Customers.Port.Models;

namespace Integrify.Integrations.Customers.Port.Driving;

public interface ICustomersIntegrationDrivingPort
{
    Task<IReadOnlyCollection<CustomerModel>> GetCustomersCollectionAsync();

    Task<CustomerModel> GetSingleCustomerAsync(Guid id);
}