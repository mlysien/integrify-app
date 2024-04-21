using Integrify.Shared.Abstractions.Commands;
using Microsoft.Extensions.Logging;

namespace Integrify.Modules.Products.Core.Commands.Handlers;

public class SynchronizeProductsHandler(ILogger<SynchronizeProductsHandler> logger) : ICommandHandler<SynchronizeProducts>
{
    public Task HandleAsync(SynchronizeProducts command, CancellationToken cancellationToken = default)
    {
        logger.LogInformation("Products synchronization started");
        
        throw new NotImplementedException();
    }
}