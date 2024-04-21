using Integrify.Shared.Abstractions.Contracts;
using Integrify.Shared.Abstractions.Messaging;
using Plugins.Inbounds.Example.Core.Events.External;

namespace Plugins.Inbounds.Example.Core.Contracts;

internal class OrderSynchronizationContract : Contract<OrderSynchronizationStarted>
{
    public OrderSynchronizationContract()
    {
        RequireAll();
    }
}