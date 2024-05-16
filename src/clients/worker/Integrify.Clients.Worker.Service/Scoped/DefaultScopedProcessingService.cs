using Integrify.Integrations.Customers.Api.Public;
using Integrify.Shared.Abstractions.Integrations;

namespace Integrify.Clients.Worker.Service.Scoped;

public sealed class DefaultScopedProcessingService(
    IList<IIntegration> integrations,
    ILogger<DefaultScopedProcessingService> logger,
    ICustomersIntegrationApi customersIntegrationApi)
    : IScopedProcessingService
{
    public async Task ProcessAsync(CancellationToken cancellationToken)
    {
        while (!cancellationToken.IsCancellationRequested)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(">> ");
            Console.ResetColor();
            var command = Console.ReadLine();

            if (string.IsNullOrEmpty(command))
            {
                Console.Clear();
                continue;
            }

            if (command.Contains("run"))
            {
                Console.WriteLine("Provide which integration you want to run?");
                foreach (var integration in integrations)
                {
                    Console.WriteLine("- {0}", integration.Name);
                }
            }
            
            
        }
    }
}