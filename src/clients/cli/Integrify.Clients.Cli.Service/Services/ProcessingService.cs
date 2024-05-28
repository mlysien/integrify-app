using Integrify.Clients.Cli.Interpreter;
using Integrify.Clients.Cli.Interpreter.Abstractions;
using Integrify.Integrations.Customers.Api.Public;
using Integrify.Integrations.Orders.Api.Public;
using Integrify.Integrations.Products.Api.Public;
using Integrify.Integrations.Stocks.Api.Public;
using Integrify.Shared.Abstractions.Integrations;
using Integrify.Shared.Abstractions.Plugins;

namespace Integrify.Clients.Cli.Service.Services;

public sealed class ProcessingService(ILogger<ProcessingService> logger,IInterpreter interpreter) : IProcessingService
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