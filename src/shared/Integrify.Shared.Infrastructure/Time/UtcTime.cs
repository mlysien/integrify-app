using Integrify.Shared.Abstractions.Time;

namespace Integrify.Shared.Infrastructure.Time;

/// <summary>
/// Implementation of IClock interface for UTC time
/// </summary>
internal sealed class UtcTime : IClock
{
    public DateTime CurrentDate() => DateTime.UtcNow;
}