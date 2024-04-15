using Integrify.Shared.Abstractions.Commands;

namespace Integrify.Modules.Stocks.Core.Commands.Handlers;

public class SynchronizeStocksHandler : ICommandHandler<SynchronizeStocks>
{
    public Task HandleAsync(SynchronizeStocks command, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}