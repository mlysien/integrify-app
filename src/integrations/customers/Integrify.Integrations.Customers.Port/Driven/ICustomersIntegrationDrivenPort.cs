using Integrify.Integrations.Customers.Port.Models;

namespace Integrify.Integrations.Customers.Port.Driven;

public interface ICustomersIntegrationDrivenPort
{
    Task SaveCustomerAsync(CustomerIntegrationModel customerIntegrationModel);
}