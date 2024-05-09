using Integrify.Modules.Customers.Port;
using Integrify.Modules.Customers.Port.Models;

namespace Plugins.FakeShop.Customers.Adapter.Source;

public class CustomerSourceAdapter : ICustomerSourcePort
{
    public async Task<IReadOnlyCollection<CustomerModel>> GetCollectionAsync()
    {
        return await Task.Run(() =>
        {
            return new List<CustomerModel>()
            {
                new()
                {
                    Id = Guid.NewGuid()
                }
            };
        });
    }
}