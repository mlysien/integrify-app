using Integrify.Shared.Abstractions.Plugins;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Plugins.FakeShop.Customers.Adapter;

namespace Plugins.FakeShop.Api;

public class FakeShopPlugin : IPlugin
{
    public string Name => "FakeShop plugin";
    
    public void Register(IServiceCollection servicesCollection)
    { 
        servicesCollection.AddCustomersAdapters();
    }

    public void Use(IApplicationBuilder app)
    { 
    }
}