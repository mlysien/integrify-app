using Integrify.Modules.Synchronizer.Core.Commands;
using Integrify.Modules.Synchronizer.Core.Integrations;
using Integrify.Shared.Abstractions.Commands;
using Integrify.Shared.Abstractions.Events;
using Integrify.Shared.Abstractions.Messaging;
using Microsoft.Extensions.Logging;
using Plugins.Inbounds.Example.Port.Api;

namespace Integrify.Modules.Synchronizer.Core.Events.Customers.External.Handlers;

internal sealed class CustomersSynchronizationRequestedHandler(ICommandDispatcher commandDispatcher)
    : IEventHandler<CustomersSynchronizationRequested>
{
    public async Task HandleAsync(CustomersSynchronizationRequested @event,
        CancellationToken cancellationToken = default)
    {
        await commandDispatcher.SendAsync(new CustomersIntegration(), cancellationToken);
    }
}