using Integrify.Shared.Abstractions.Events;
using Integrify.Shared.Abstractions.Messaging;
using Microsoft.Extensions.Logging;
using Plugins.Inbounds.Example.Port.Api;

namespace Integrify.Modules.Synchronizer.Core.Events.Customers.External.Handlers;

internal sealed class CustomersSynchronizationRequestedHandler(
    IMessageBroker messageBroker,
    ILogger<CustomersSynchronizationRequestedHandler> logger,
    IInboundCustomersApi customersApi): IEventHandler<CustomersSynchronizationRequested>
{
    public async Task HandleAsync(CustomersSynchronizationRequested @event, CancellationToken cancellationToken = default)
    {
        var customersCollection = await customersApi.GetCustomersCollectionAsync();
        
        logger.LogInformation("Fetched {0} customers", customersCollection.Count);

        if (customersCollection is { Count: > 0 })
        {
            foreach (var customerDto in customersCollection)
            {
                logger.LogInformation("Working on Customer with Id: {0}, Name: {1}", customerDto.Id, customerDto.Name);
            }
        }
        
        await messageBroker.PublishAsync(new CustomersSynchronizationFinished(customersCollection.Count), cancellationToken);
    }
}