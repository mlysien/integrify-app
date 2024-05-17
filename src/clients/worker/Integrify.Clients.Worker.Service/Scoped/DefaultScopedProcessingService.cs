using Integrify.Integrations.Customers.Api.Public;
using Integrify.Shared.Abstractions.Integrations;
using Integrify.Shared.Abstractions.Plugins;

namespace Integrify.Clients.Worker.Service.Scoped;

public sealed class DefaultScopedProcessingService(
    IList<IIntegration> integrations,
    IList<IPlugin> plugins,
    ILogger<DefaultScopedProcessingService> logger,
    ICustomersIntegrationApi customersIntegrationApi)
    : IScopedProcessingService
{
    public async Task ProcessAsync(CancellationToken cancellationToken)
    {
        while (!cancellationToken.IsCancellationRequested)
        {
            var command = ReadInput();

            if (string.IsNullOrEmpty(command))
            {
                Console.Clear();
                continue;
            }

            switch (command.ToLower())
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
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.Write(">> ");
        Console.ResetColor();
        var command = Console.ReadLine();
        return command;
    }

    private void PrintLoadedPlugins()
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
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