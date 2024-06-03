using Integrify.Clients.Cli.Service.Services;
using Integrify.Shared.Abstractions.Initializer;

namespace Integrify.Clients.Cli.Service;

public sealed class Worker(
    ILogger<Worker> logger,
    IInitializer initializer,
    IServiceScopeFactory serviceScopeFactory) 
    : BackgroundService
{
    protected override async Task ExecuteAsync(CancellationToken cancellationToken)
    {
        logger.PrintBanner();
        PrintInitializing();
        await initializer.InitializeAsync();
        
        logger.LogInformation("{0} service is running.", "Integrify");

        await RunAsync(cancellationToken);
    }

    private async Task RunAsync(CancellationToken stoppingToken)
    {
        using var scope = serviceScopeFactory.CreateScope();
        var scopedProcessingService = scope.ServiceProvider.GetRequiredService<IProcessingService>();

        await scopedProcessingService.ProcessAsync(stoppingToken);
    }

    public override async Task StopAsync(CancellationToken stoppingToken)
    {
        logger.LogInformation("{0} service has been stopped.", "Integrify");
        
        await base.StopAsync(stoppingToken);
    }


    private void PrintInitializing()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Initializing Integrify...");
        Console.ResetColor();
    }
}