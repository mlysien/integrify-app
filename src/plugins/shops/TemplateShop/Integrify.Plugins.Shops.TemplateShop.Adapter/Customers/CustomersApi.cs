using Integrify.Modules.Customers.Port.Api;
using Integrify.Modules.Customers.Port.Dto;

namespace Integrify.Plugins.Shops.TemplateShop.Adapter.Customers;

internal class CustomersApi : ICustomerSourceApi
{
    public async Task<IReadOnlyCollection<CustomerSourceDto>> GetCustomersCollectionAsync()
    {
        return await Task.Run(() => new List<CustomerSourceDto>()
        {
            new()
            {
                Id = Guid.NewGuid()
            }
        });
    }
}