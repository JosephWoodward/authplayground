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

/*
            var client = new HttpClient();
            var response = await client.RequestAuthorizationCodeTokenAsync(new AuthorizationCodeTokenRequest
            {
                Code = request.Code,
                ClientId = "mvc",
                ClientSecret = "49C1A7E1-0C79-4A89-A3D6-A37998FB86B0".Sha256(),
                Address = "http://localhost:5000/connect/token",
                RedirectUri = "http://localhost:5002/callback",
                GrantType = "code"
            });
*/

            return View(request);
        }
    }

}