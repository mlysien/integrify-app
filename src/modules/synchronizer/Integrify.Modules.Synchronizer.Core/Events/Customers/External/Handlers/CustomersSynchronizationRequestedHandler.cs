using Integrify.Modules.Synchronizer.Core.Synchronizations;
using Integrify.Shared.Abstractions.Events;
using Integrify.Shared.Abstractions.Synchronizations;

namespace Integrify.Modules.Synchronizer.Core.Events.Customers.External.Handlers;

internal sealed class CustomersSynchronizationRequestedHandler(ISynchronizationDispatcher synchronizationDispatcher)
    : IEventHandler<CustomersSynchronizationRequested>
{
    public async Task HandleAsync(CustomersSynchronizationRequested @event,
        CancellationToken cancellationToken = default)
    {
        await synchronizationDispatcher.SendAsync(new CustomersSynchronization(), cancellationToken);
    }
}