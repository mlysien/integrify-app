using Integrify.Modules.Customers.Port.Api;
using Integrify.Plugins.Shops.TemplateShop.Adapter.Customers;
using Microsoft.Extensions.DependencyInjection;

namespace Integrify.Plugins.Shops.TemplateShop.Adapter;

public static class Extensions
{
    public static void AddAdapterLayer(this IServiceCollection servicesCollection)
    {
        servicesCollection.AddScoped<ICustomerSourceApi, CustomersApi>();
    }
}