using System.Threading.Channels;
using Integrify.Shared.Abstractions.Events;
using Integrify.Shared.Abstractions.Messaging;

namespace Integrify.Shared.Infrastructure.Messaging;

internal sealed class EventChannel : IEventChannel
{
    private readonly Channel<IEvent> _messages = Channel.CreateUnbounded<IEvent>();

    public ChannelReader<IEvent> Reader => _messages.Reader;
    public ChannelWriter<IEvent> Writer => _messages.Writer;
}