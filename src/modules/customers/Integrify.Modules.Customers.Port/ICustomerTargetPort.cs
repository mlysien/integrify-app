using Integrify.Modules.Customers.Port.Models;

namespace Integrify.Modules.Customers.Port;

public interface ICustomerTargetPort
{
    Task SaveAsync(CustomerModel customerModel);
}