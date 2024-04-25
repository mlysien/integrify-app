using Integrify.Modules.Synchronizer.Core.Events.Customers;
using Integrify.Shared.Abstractions.Integrations;
using Integrify.Shared.Abstractions.Messaging;
using Microsoft.Extensions.Logging;
using Plugins.Inbounds.Example.Port.Api;

namespace Integrify.Modules.Synchronizer.Core.Integrations.Handlers;

public class CustomersIntegrationHandler(
    ILogger<CustomersIntegrationHandler> logger,
    IInboundCustomersApi customersApi, 
    IMessageBroker messageBroker)
    : IIntegrationHandler<CustomersIntegration>
{
    public async Task HandleAsync(CustomersIntegration command, CancellationToken cancellationToken = default)
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