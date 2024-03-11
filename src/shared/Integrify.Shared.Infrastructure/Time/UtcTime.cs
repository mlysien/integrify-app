using Integrify.Shared.Abstractions.Time;

namespace Integrify.Shared.Infrastructure.Time;


public class UtcTime : IClock
{
    public DateTime CurrentDate() => DateTime.UtcNow;
}