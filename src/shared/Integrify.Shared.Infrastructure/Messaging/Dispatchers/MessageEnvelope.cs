using Integrify.Shared.Abstractions.Messaging;

namespace Integrify.Shared.Infrastructure.Messaging.Dispatchers;

internal record MessageEnvelope(IMessage Message, IMessageContext MessageContext);