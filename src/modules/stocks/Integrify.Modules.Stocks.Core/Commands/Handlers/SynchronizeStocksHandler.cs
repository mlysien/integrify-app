using Integrify.Modules.Stocks.Core.Events;
using Integrify.Shared.Abstractions.Commands;
using Integrify.Shared.Abstractions.Messaging;
using Microsoft.Extensions.Logging;

namespace Integrify.Modules.Stocks.Core.Commands.Handlers;

public class SynchronizeStocksHandler(  
    ILogger<SynchronizeStocksHandler> logger, 
    IMessageBroker messageBroker) : ICommandHandler<SynchronizeStocks>
{
    public async Task HandleAsync(SynchronizeStocks command, CancellationToken cancellationToken = default)
    {
        logger.LogInformation("Stocks synchronization started");

        await messageBroker.PublishAsync(new StocksSynchronizationRequested(), cancellationToken);
    }
}