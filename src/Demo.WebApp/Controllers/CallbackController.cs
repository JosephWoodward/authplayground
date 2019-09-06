using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using Demo.WebApp.Models;
using IdentityModel.Client;
using IdentityServer4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Demo.WebApp.Controllers
{
    public class CallbackController : Controller
    {
        private readonly ILogger<CallbackController> _logger;

        public CallbackController(ILogger<CallbackController> logger)
        {
            _logger = logger;
        }
        
        public async Task<IActionResult> Index(CallbackRequest request)
        {
            _logger.LogDebug("Callback response", request);

            var client = new HttpClient();
            var response = await client.RequestTokenAsync(new TokenRequest
            {
                Address = "https://demo.identityserver.io/connect/token",
                GrantType = "custom",

                ClientId = "client",
                ClientSecret = "secret",

                Parameters =
                {
                    { "custom_parameter", "custom value"},
                    { "scope", "api1" }
                }
            });

            return View(request);
        }
    }

}