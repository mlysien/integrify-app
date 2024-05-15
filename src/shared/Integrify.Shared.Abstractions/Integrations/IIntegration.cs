using Microsoft.Extensions.DependencyInjection;

namespace Integrify.Shared.Abstractions.Integrations;

public interface IIntegration
{
    string Name { get; }
 
    void AddIntegrationDependencies(IServiceCollection serviceCollection);
}