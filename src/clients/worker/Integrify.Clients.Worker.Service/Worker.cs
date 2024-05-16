using Integrify.Clients.Worker.Service.Scoped;

namespace Integrify.Clients.Worker.Service;

public sealed class Worker(
    IServiceScopeFactory serviceScopeFactory,
    ILogger<Worker> logger) : BackgroundService
{
    protected override async Task ExecuteAsync(CancellationToken cancellationToken)
    {
        logger.PrintBanner();
        logger.LogInformation("{0} service is running.", "Integrify");

        await RunAsync(cancellationToken);
    }

    private async Task RunAsync(CancellationToken stoppingToken)
    {
        using var scope = serviceScopeFactory.CreateScope();
        var scopedProcessingService = scope.ServiceProvider.GetRequiredService<IScopedProcessingService>();

        await scopedProcessingService.ProcessAsync(stoppingToken);
    }

    public override async Task StopAsync(CancellationToken stoppingToken)
    {
        logger.LogInformation("{0} service has been stopped.", "Integrify");
        
        await base.StopAsync(stoppingToken);
    }
}