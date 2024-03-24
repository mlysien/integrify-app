using Integrify.Shared.Abstractions.Contexts;
using Integrify.Shared.Abstractions.Messaging;

namespace Integrify.Shared.Infrastructure.Messaging.Contexts;

public class MessageContext(Guid messageId, IContext context) : IMessageContext
{
    public Guid MessageId { get; } = messageId;
    public IContext Context { get; } = context;
}