using Integrify.Modules.Customers.Core.Events;
using Integrify.Modules.Customers.Port.Api;
using Integrify.Shared.Abstractions.Commands;
using Integrify.Shared.Abstractions.Messaging;
using Microsoft.Extensions.Logging;

namespace Integrify.Modules.Customers.Core.Commands.Handlers;

internal class SynchronizeCustomersHandler(
    ILogger<SynchronizeCustomersHandler> logger,
    ICustomerSourceApi sourceApi,
    IMessageBroker messageBroker) : ICommandHandler<SynchronizeCustomers>
{
    public async Task HandleAsync(SynchronizeCustomers command, CancellationToken cancellationToken = default)
    { 
        logger.LogInformation("Customers synchronization started");


        var collection = await sourceApi.GetCustomersCollectionAsync();

        foreach (var dto in collection)
        {
            var a = dto.Id;
        }
        
        await messageBroker.PublishAsync(new CustomersSynchronizationRequested(), cancellationToken);
    }
}