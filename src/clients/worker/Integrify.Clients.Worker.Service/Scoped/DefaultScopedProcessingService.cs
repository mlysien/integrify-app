using Integrify.Integrations.Customers.Api.Public;
using Integrify.Integrations.Orders.Api.Public;
using Integrify.Integrations.Products.Api.Public;
using Integrify.Integrations.Stocks.Api.Public;
using Integrify.Shared.Abstractions.Integrations;
using Integrify.Shared.Abstractions.Plugins;

namespace Integrify.Clients.Worker.Service.Scoped;

public sealed class DefaultScopedProcessingService(
    ILogger<DefaultScopedProcessingService> logger,
    IList<IIntegration> integrations,
    IList<IPlugin> plugins,
    ICustomersIntegrationApi customersIntegrationApi,
    IOrdersIntegrationApi ordersIntegrationApi,
    IProductsIntegrationApi productsIntegrationApi,
    IStocksIntegrationApi stocksIntegrationApi) : IScopedProcessingService
{
    public async Task ProcessAsync(CancellationToken cancellationToken)
    {
        while (!cancellationToken.IsCancellationRequested)
        {
            var command = ReadInput()?.ToLower();

            if (string.IsNullOrEmpty(command))
            {
                Console.Clear();
                logger.PrintBanner();
                continue;
            }

            if (command.Contains("sync"))
            {
                var customersApi = nameof(customersIntegrationApi);
                var ordersApi = nameof(ordersIntegrationApi);
                var productsApi = nameof(productsIntegrationApi);
                var stocksApi = nameof(stocksIntegrationApi);
                
                foreach (var integration in integrations)
                {
                    if (command.Contains(integration.Name.ToLower()))
                    {
                        if (customersApi.Contains(integration.Name.ToLower()))
                        {
                            await customersIntegrationApi.RunIntegration();
                        }
                        
                        if (ordersApi.Contains(integration.Name.ToLower()))
                        {
                            await ordersIntegrationApi.RunIntegration();
                        }
                        
                        if (productsApi.Contains(integration.Name.ToLower()))
                        {
                            await productsIntegrationApi.RunIntegration();
                        }
                        
                        if (stocksApi.Contains(integration.Name.ToLower()))
                        {
                            await stocksIntegrationApi.RunIntegration();
                        }
                    }
                }
                
            }
            
            switch (command)
            {
                case "integrations":
                    PrintAvailableIntegrations();
                    break;
                case "plugins":
                    PrintLoadedPlugins();
                    break;
            }
        }
    }

    private string? ReadInput()
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write(">> ");
        Console.ResetColor();
        var command = Console.ReadLine();
        return command;
    }

    private void PrintLoadedPlugins()
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Loaded plugins:");
        Console.ResetColor();
        foreach (var plugin in plugins)
        {            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("* ");
            Console.ResetColor();
            Console.WriteLine(plugin.Name);
        }
    }
    
    private void PrintAvailableIntegrations()
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("Available integrations:");
        Console.ResetColor();
        foreach (var integration in integrations)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("* ");
            Console.ResetColor();
            Console.WriteLine(integration.Name);
        }
    }
}