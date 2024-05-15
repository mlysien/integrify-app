using Integrify.Integrations.Customers.Core;
using Integrify.Integrations.Customers.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Integrify.Integrations.Customers.Api.Controllers;

[ApiController]
[Route("[controller]/[action]")]
internal class CustomersIntegrationController(ICustomersIntegration customersIntegration) : Controller
{
    [HttpPost]
    [SwaggerOperation("Begin customers integration process")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status503ServiceUnavailable)]
    public async Task<ActionResult> Synchronize()
    {
        await customersIntegration.RunIntegration();
        
        return Ok();
    }
}