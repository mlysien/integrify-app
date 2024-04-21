using Integrify.Modules.Products.Core.Events;
using Integrify.Shared.Abstractions.Commands;
using Integrify.Shared.Abstractions.Messaging;
using Microsoft.Extensions.Logging;

namespace Integrify.Modules.Products.Core.Commands.Handlers;

public class SynchronizeProductsHandler(
    ILogger<SynchronizeProductsHandler> logger, 
    IMessageBroker messageBroker) : ICommandHandler<SynchronizeProducts>
{
    public async Task HandleAsync(SynchronizeProducts command, CancellationToken cancellationToken = default)
    {
        logger.LogInformation("Products synchronization started");

        await messageBroker.PublishAsync(new ProductsSynchronizationRequested(), cancellationToken);
    }
}