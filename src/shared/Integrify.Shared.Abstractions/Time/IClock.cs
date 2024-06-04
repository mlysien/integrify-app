namespace Integrify.Shared.Abstractions.Time;

/// <summary>
/// Provides methods for get information about time
/// </summary>
public interface IClock
{
    /// <summary>
    /// Returns current UTC time in ticks
    /// </summary>
    long NowTicks();

    DateTime NowDateTime();
}