using Integrify.Clients.Cli.Interpreter;
using Integrify.Integrations.Customers.Api.Public;
using Integrify.Integrations.Orders.Api.Public;
using Integrify.Integrations.Products.Api.Public;
using Integrify.Integrations.Stocks.Api.Public;
using Integrify.Shared.Abstractions.Integrations;
using Integrify.Shared.Abstractions.Plugins;

namespace Integrify.Clients.Cli.Service.Services;

public sealed class ProcessingService(
    ILogger<ProcessingService> logger,
    IInterpreter interpreter,
    IList<IIntegration> integrations,
    IList<IPlugin> plugins,
    ICustomersIntegrationApi customersIntegrationApi,
    IOrdersIntegrationApi ordersIntegrationApi,
    IProductsIntegrationApi productsIntegrationApi,
    IStocksIntegrationApi stocksIntegrationApi) : IProcessingService
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

            await interpreter.Interpret(command);
            
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
}