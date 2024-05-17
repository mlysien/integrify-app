using Integrify.Integrations.Customers.Port.Models;

namespace Integrify.Integrations.Customers.Port.Driving;

public interface ICustomersIntegrationDrivingPort
{
    Task<IReadOnlyCollection<CustomerIntegrationModel>> GetCustomersCollectionAsync();

    Task<CustomerIntegrationModel> GetSingleCustomerAsync(Guid id);
}