using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.AspNetCore.Mvc;

namespace SampleNewsWebsite.Controllers
{
    public class OidcConfigurationController : Controller
    {
        [ResponseCache(NoStore = true)]
        [HttpGet("_configuration/{clientId}")]
        public IActionResult GetClientRequestParameters([FromServices] IClientRequestParametersProvider parametersProvider, [FromRoute] string clientId)
        {
            return Ok(parametersProvider.GetClientParameters(HttpContext, clientId));
        }
    }
}
