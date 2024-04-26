using Integrify.Modules.Synchronizer.Core.Events.Customers;
using Integrify.Shared.Abstractions.Messaging;
using Integrify.Shared.Abstractions.Synchronizations;
using Microsoft.Extensions.Logging;

namespace Integrify.Modules.Synchronizer.Core.Synchronizations.Handlers;

public class CustomersSynchronizationHandler(
    ILogger<CustomersSynchronizationHandler> logger,
    IMessageBroker messageBroker)
    : ISynchronizationHandler<CustomersSynchronization>
{
    public async Task HandleAsync(CustomersSynchronization command, CancellationToken cancellationToken = default)
    {
        await messageBroker.PublishAsync(new CustomersSynchronizationFinished(1),
            cancellationToken);
    }
}