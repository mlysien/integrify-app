using Integrify.Plugins.ErpSimulator.Domain.Repositories;
using Integrify.Plugins.ErpSimulator.Domain.Repositories.Abstractions;
using Microsoft.Extensions.DependencyInjection;

namespace Integrify.Plugins.ErpSimulator.Domain;

public static class Extensions
{
    public static void AddErpSimulatorDomain(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<IProductRepository, ProductRepository>();
        serviceCollection.AddScoped<ICustomerRepository, CustomerRepository>();
        serviceCollection.AddScoped<IOrderRepository, OrderRepository>();
        serviceCollection.AddScoped<IStockRepository, StockRepository>();
    }
}