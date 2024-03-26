using Integrify.Shared.Abstractions.Messaging;
using Microsoft.Extensions.Caching.Memory;

namespace Integrify.Shared.Infrastructure.Messaging.Contexts;

public class MessageContextProvider(IMemoryCache cache) : IMessageContextProvider
{
    public IMessageContext Get(IMessage message) => cache.Get<IMessageContext>(message);
}