using Integrify.Modules.Synchronizer.Core.Integrations;
using Integrify.Shared.Abstractions.Commands;

namespace Integrify.Modules.Synchronizer.Core.Commands.Handlers;

internal sealed class StocksSynchronizationHandler : ICommandHandler<StocksIntegration>
{
    public Task HandleAsync(StocksIntegration command, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}