using Integrify.Shared.Abstractions.Events;

namespace Integrify.Modules.Synchronizer.Core.Events.Customers;

internal record CustomersSynchronizationFinished(int synchronizedCustomers) : IEvent;