using Integrify.Modules.Customers.Port;
using Microsoft.Extensions.DependencyInjection;
using Plugins.FakeShop.Customers.Adapter.Source;
using Plugins.FakeShop.Customers.Adapter.Target;

namespace Plugins.FakeShop.Customers.Adapter;

public static class Extensions
{
    public static void AddCustomersAdapters(this IServiceCollection servicesCollection)
    {
        servicesCollection.AddScoped<ICustomerSourcePort, CustomerSourceAdapter>();
        servicesCollection.AddScoped<ICustomerTargetPort, CustomerTargetAdapter>();
    }
}