using Integrify.Modules.Synchronizer.Core.Events.Customers;
using Integrify.Shared.Abstractions.Messaging;
using Integrify.Shared.Abstractions.Synchronizations;
using Microsoft.Extensions.Logging;
using Plugins.Inbounds.Example.Port.Api;

namespace Integrify.Modules.Synchronizer.Core.Synchronizations.Handlers;

public class CustomersSynchronizationHandler(
    ILogger<CustomersSynchronizationHandler> logger,
    IInboundCustomersApi customersApi, 
    IMessageBroker messageBroker)
    : ISynchronizationHandler<CustomersSynchronization>
{
    public async Task HandleAsync(CustomersSynchronization command, CancellationToken cancellationToken = default)
    {
        var customersCollection = await customersApi.GetCustomersCollectionAsync();

        logger.LogInformation("Received {0} customers", customersCollection.Count);

        foreach (var customer in customersCollection)
        {
            logger.LogInformation("Processing Customer with Id: {0}, Name: {1}", customer.Id, customer.Name);
        }

        await messageBroker.PublishAsync(new CustomersSynchronizationFinished(customersCollection.Count),
            cancellationToken);
    }
}