using Integrify.Modules.Synchronizer.Core.Integrations;
using Integrify.Shared.Abstractions.Events;
using Integrify.Shared.Abstractions.Integrations;

namespace Integrify.Modules.Synchronizer.Core.Events.Customers.External.Handlers;

internal sealed class CustomersSynchronizationRequestedHandler(IIntegrationDispatcher integrationDispatcher)
    : IEventHandler<CustomersSynchronizationRequested>
{
    public async Task HandleAsync(CustomersSynchronizationRequested @event,
        CancellationToken cancellationToken = default)
    {
        await integrationDispatcher.SendAsync(new CustomersIntegration(), cancellationToken);
    }
}