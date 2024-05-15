using Microsoft.Extensions.DependencyInjection;

namespace Integrify.Shared.Abstractions.Integrations;

public interface IIntegration
{
    void AddIntegrationDependencies(IServiceCollection serviceCollection);
}