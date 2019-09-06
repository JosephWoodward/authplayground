using Microsoft.AspNetCore.Mvc;

namespace Demo.WebApp.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            /*
             Notes:
             Notice how there's no mention of grant types yet, that comes after when exchanging 'code' for token.
             OAuth Spec says redirect_uri is optional (https://tools.ietf.org/html/rfc6749#section-4.1.1),
             but t appears that IdentityServer seems to enforce it?
            */
            var url =
                "http://localhost:5000/connect/authorize?" +
                "client_id=mvc" +
                "&response_type=code" +
                "&scope=openid" +
                "&redirect_uri=http%3A%2F%2Flocalhost%3A5002/callback" +
                "&state=state-296bc9a0-a2a2-4a57-be1a-d0e2fd9bb601";

            return Redirect(url);
        }
    }
}