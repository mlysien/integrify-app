using Integrify.Integrations.Orders.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Integrify.Integrations.Orders.Api.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class OrdersIntegrationController(IOrdersIntegration ordersIntegration) : Controller
{
    [HttpPost]
    [SwaggerOperation("Begin orders integration process")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status503ServiceUnavailable)]
    public async Task<ActionResult> Synchronize()
    {
        await ordersIntegration.RunIntegration();
        
        return Ok();
    }
}