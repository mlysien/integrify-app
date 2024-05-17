using Integrify.Shared.Abstractions.Integrations;

namespace Integrify.Shared.Abstractions.Ports;

public interface IDrivingPort<T> where T: class, IIntegrationModel
{
    Task<IReadOnlyCollection<T>> FetchCollectionAsync();

    Task<T> GetSingleAsync(Guid id);
}