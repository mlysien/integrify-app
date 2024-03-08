namespace Integrify.Shared.Abstractions.Time;

/// <summary>
/// Interface for fetching time
/// </summary>
public interface IClock
{
    /// <summary>
    /// Returns current UTC date 
    /// </summary>
    DateTime CurrentDate();
}