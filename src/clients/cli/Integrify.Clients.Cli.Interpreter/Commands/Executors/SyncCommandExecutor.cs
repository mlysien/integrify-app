using Integrify.Clients.Cli.Interpreter.Commands.Abstractions;
using Integrify.Integrations.Customers.Api.Public;
using Integrify.Integrations.Orders.Api.Public;
using Integrify.Integrations.Products.Api.Public;
using Integrify.Integrations.Stocks.Api.Public;
using Integrify.Shared.Abstractions.Integrations;

namespace Integrify.Clients.Cli.Interpreter.Commands.Executors;

public class SyncCommandExecutor(
    ICustomersIntegrationApi customersIntegrationApi, 
    IOrdersIntegrationApi ordersIntegrationApi, 
    IProductsIntegrationApi productsIntegrationApi, 
    IStocksIntegrationApi stocksIntegrationApi
    ): ISyncCommand
{
    public string Keyword => "sync";
    
    public async Task Execute(params string[] options)
    {
        if (!options.Any())
        {
            Help();
            return;
        }

        var integrationApis = new Dictionary<string, IIntegrationApi>
        {
            { nameof(customersIntegrationApi).Replace("IntegrationApi", string.Empty), customersIntegrationApi },
            { nameof(ordersIntegrationApi).Replace("IntegrationApi", string.Empty), ordersIntegrationApi },
            { nameof(productsIntegrationApi).Replace("IntegrationApi", string.Empty), productsIntegrationApi },
            { nameof(stocksIntegrationApi).Replace("IntegrationApi", string.Empty), stocksIntegrationApi }
        };

        var area = options.FirstOrDefault()?.ToLower();
        var integrationApi = integrationApis.FirstOrDefault(api => area != null && api.Key.Equals(area)).Value;
        
        if (integrationApi is not null)
        {
            await integrationApi.RunIntegrationAsync();
        }
    }

    public void Help()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write($"{Keyword}");
        Console.ResetColor();
        Console.WriteLine(" - begin synchronization process of specified integration area.");
        Console.Write("How to use: ");
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine($"{Keyword} [integration area]");
        Console.ResetColor();
    }
}