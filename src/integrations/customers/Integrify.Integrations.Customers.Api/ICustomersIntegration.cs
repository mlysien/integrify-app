using Integrify.Shared.Abstractions.Integrations;

namespace Integrify.Integrations.Customers.Api;

public interface ICustomersIntegration : IIntegration
{
    Task BeginIntegration();
}