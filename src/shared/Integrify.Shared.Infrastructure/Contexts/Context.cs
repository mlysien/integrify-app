using Integrify.Shared.Abstractions.Contexts;
using Microsoft.AspNetCore.Http;

namespace Integrify.Shared.Infrastructure.Contexts;

public class Context(Guid? correlationId, string traceId, string ipAddress = null, string userAgent = null)
    : IContext
{
    public Guid RequestId { get; } = Guid.NewGuid();
    public Guid CorrelationId { get; } = correlationId ?? Guid.NewGuid();
    public string TraceId { get; } = traceId;
    public string IpAddress { get; } = ipAddress;
    public string UserAgent { get; } = userAgent;

    public Context() : this(Guid.NewGuid(), $"{Guid.NewGuid():N}", null)
    {
    }

    public Context(HttpContext context) : this(context.TryGetCorrelationId(), context.TraceIdentifier, context.Request.Headers["user-agent"])
    {
    }

    public static IContext Empty => new Context();
}