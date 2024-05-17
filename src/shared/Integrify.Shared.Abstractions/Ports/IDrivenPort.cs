using Integrify.Shared.Abstractions.Integrations;

namespace Integrify.Shared.Abstractions.Ports;

public interface IDrivenPort<in T> where T: class, IIntegrationModel
{
    Task PushAsync(T integrationModel);
}