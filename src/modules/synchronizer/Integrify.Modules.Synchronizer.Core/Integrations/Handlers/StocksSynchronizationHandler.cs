using Integrify.Shared.Abstractions.Commands;

namespace Integrify.Modules.Synchronizer.Core.Integrations.Handlers;

internal sealed class StocksSynchronizationHandler : ICommandHandler<StocksIntegration>
{
    public Task HandleAsync(StocksIntegration command, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}