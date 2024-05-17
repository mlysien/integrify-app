using Integrify.Plugins.ErpSimulator.Customers.Adapter;
using Integrify.Plugins.ErpSimulator.Orders.Adapter;
using Integrify.Plugins.ErpSimulator.Products.Adapter;
using Integrify.Plugins.ErpSimulator.Stocks.Adapter;
using Integrify.Shared.Abstractions.Plugins;
using Microsoft.Extensions.DependencyInjection;

namespace Integrify.Plugins.ErpSimulator.Api;

public class ErpSimulatorPlugin : IPlugin
{
    public string Name => "Erp simulator";
    
    public void AddPluginDependencies(IServiceCollection serviceCollection)
    {
        serviceCollection.AddCustomersAdapters();
        serviceCollection.AddOrdersAdapters();
        serviceCollection.AddProductsAdapters();
        serviceCollection.AddStocksAdapters();
    }
}