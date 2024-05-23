namespace Integrify.Clients.Cli.Service.Services;

public interface IProcessingService
{
    Task ProcessAsync(CancellationToken cancellationToken);
}