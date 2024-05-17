using Integrify.Integrations.Orders.Api.Public;
using Integrify.Integrations.Orders.Core.Services;

namespace Integrify.Integrations.Orders.Api.Services;

internal sealed class OrdersIntegrationApi(IOrdersIntegrationProcess ordersIntegrationProcess) : IOrdersIntegrationApi
{
    public async Task RunIntegration()
    {
        await ordersIntegrationProcess.ExecuteOrdersIntegrationProcess();
    }
}