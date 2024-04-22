using Integrify.Modules.Synchronizer.Core.Events.Stocks.External;
using Integrify.Shared.Abstractions.Contracts;
using Integrify.Shared.Abstractions.Messaging;

namespace Integrify.Modules.Synchronizer.Core.Contracts;

[Message("stocks")]
internal class StocksSynchronizationContract: Contract<StocksSynchronizationRequested>
{
    public StocksSynchronizationContract()
    {
        RequireAll();
    }
}