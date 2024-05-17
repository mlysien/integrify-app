using Integrify.Plugins.ShopSimulator.Customers.Adapter;
using Integrify.Plugins.ShopSimulator.Orders.Adapter;
using Integrify.Plugins.ShopSimulator.Products.Adapter;
using Integrify.Plugins.ShopSimulator.Stocks.Adapter;
using Integrify.Shared.Abstractions.Plugins;
using Microsoft.Extensions.DependencyInjection;

namespace Integrify.Plugins.ShopSimulator.Api;

public class ShopSimulatorPlugin : IPlugin
{
    public void AddPluginDependencies(IServiceCollection serviceCollection)
    {
        serviceCollection.AddCustomersAdapters();
        serviceCollection.AddOrdersAdapters();
        serviceCollection.AddProductsAdapters();
        serviceCollection.AddStocksAdapters();
    }
}