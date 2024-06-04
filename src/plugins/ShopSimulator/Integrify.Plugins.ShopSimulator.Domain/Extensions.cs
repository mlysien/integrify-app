using Integrify.Plugins.ShopSimulator.Domain.Repositories;
using Integrify.Plugins.ShopSimulator.Domain.Repositories.Abstractions;
using Microsoft.Extensions.DependencyInjection;

namespace Integrify.Plugins.ShopSimulator.Domain;

public static class Extensions
{
    public static void AddShopSimulatorDomain(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<IProductRepository, ProductRepository>();
        serviceCollection.AddScoped<ICustomerRepository, CustomerRepository>();
        serviceCollection.AddScoped<IOrderRepository, OrderRepository>();
        serviceCollection.AddScoped<IStockRepository, StockRepository>();
    }
}