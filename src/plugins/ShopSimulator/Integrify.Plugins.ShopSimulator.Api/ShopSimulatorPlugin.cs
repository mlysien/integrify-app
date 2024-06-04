using Integrify.Plugins.ShopSimulator.Customers.Adapter;
using Integrify.Plugins.ShopSimulator.Domain;
using Integrify.Plugins.ShopSimulator.Orders.Adapter;
using Integrify.Plugins.ShopSimulator.Products.Adapter;
using Integrify.Plugins.ShopSimulator.Stocks.Adapter;
using Integrify.Shared.Abstractions.Plugins;
using Microsoft.Extensions.DependencyInjection;

namespace Integrify.Plugins.ShopSimulator.Api;

internal sealed class ShopSimulatorPlugin : IPlugin
{
    public string Name => "Shop simulator";

    public void AddPluginDependencies(IServiceCollection serviceCollection)
    {
        serviceCollection.AddShopSimulatorDomain();
        serviceCollection.AddCustomersAdapters();
        serviceCollection.AddOrdersAdapters();
        serviceCollection.AddProductsAdapters();
        serviceCollection.AddStocksAdapters();
    }
}