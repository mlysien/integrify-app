using Integrify.Integrations.Customers.Api.Public;
using Integrify.Integrations.Customers.Core;
using Integrify.Shared.Abstractions.Integrations;
using Microsoft.Extensions.DependencyInjection;

namespace Integrify.Integrations.Customers.Api;

internal sealed class CustomersIntegration : IIntegration
{
    public string Name => "Customers";

    public void AddIntegrationDependencies(IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<ICustomersIntegrationApi, CustomerIntegrationApi>();
        serviceCollection.AddCustomersIntegrationCoreLayer();
    }
}