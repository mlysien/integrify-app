namespace Integrify.Shared.Abstractions.Initializer;

/// <summary>
/// Provides methods for initialize application environment
/// </summary>
public interface IInitializer
{
    Task InitializeAsync();
}