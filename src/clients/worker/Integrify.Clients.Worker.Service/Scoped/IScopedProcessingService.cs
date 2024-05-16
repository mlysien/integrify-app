namespace Integrify.Clients.Worker.Service.Scoped;

public interface IScopedProcessingService
{
    Task ProcessAsync(CancellationToken cancellationToken);
}