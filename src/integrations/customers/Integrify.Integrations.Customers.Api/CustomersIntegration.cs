using Microsoft.Extensions.DependencyInjection;

namespace Integrify.Integrations.Customers.Api;

internal sealed class CustomersIntegration : ICustomersIntegration
{
    public Task BeginIntegration()
    {
        throw new NotImplementedException();
    }

    public void Register(IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<ICustomersIntegration, CustomersIntegration>();
    }
}