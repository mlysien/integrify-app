using Integrify.Integrations.Customers.Api;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Integrify.Gateway.Api.Controllers;

[ApiController]
[Route("[controller]/[action]")]
internal class CustomersIntegrationController(ICustomersIntegration customersIntegration) : Controller
{
    [HttpPost]
    [SwaggerOperation("Begin customers integration process")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status503ServiceUnavailable)]
    public async Task<ActionResult> Start()
    {
        await customersIntegration.BeginIntegration();
        
        return Ok();
    }
}