using Integrify.Modules.Customers.Port;
using Integrify.Modules.Customers.Port.Models;

namespace Plugins.FakeShop.Customers.Adapter.Target;

public class CustomerTargetAdapter : ICustomerTargetPort
{
    public Task SaveAsync(CustomerModel customerModel)
    {
        return Task.CompletedTask;
    }
}