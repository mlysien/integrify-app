namespace Integrify.Clients.Worker.Service.Scoped;

public sealed class DefaultScopedProcessingService(ILogger<DefaultScopedProcessingService> logger)
    : IScopedProcessingService
{
    public Task ProcessAsync(CancellationToken cancellationToken)
    {
        // todo integration flow process here
        return Task.CompletedTask;
    }
}