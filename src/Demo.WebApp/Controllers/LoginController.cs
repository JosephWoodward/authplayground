using System.Text;
using IdentityModel;
using IdentityServer4.Models;
using Microsoft.AspNetCore.Mvc;

namespace Demo.WebApp.Controllers
{
    public static class PkceCodes
    {
        public static string CodeVerifier = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
        
        public static string CodeChallengePlain = CodeVerifier;

        public static string CodeChallengeSha256 = Base64Url.Encode(Encoding.ASCII.GetBytes(CodeVerifier).Sha256());
    }
    
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            /*
             Notes:
             OAuth Spec says redirect_uri is optional (https://tools.ietf.org/html/rfc6749#section-4.1.1),
             but it appears that IdentityServer seems to enforce it?
            */

            var clientId = "mvcpkce";
            
            var url =
                "http://localhost:5000/connect/authorize?" +
                "client_id=" + clientId +
                "&response_type=code" +
                "&scope=openid" +
/*
                "&code_challenge=" + PkceCodes.CodeChallengePlain + "" +
                "&code_challenge_method=plain" +
*/
                "&code_challenge=" + PkceCodes.CodeChallengeSha256 + "" +
                "&code_challenge_method=S256" +
                "&redirect_uri=http%3A%2F%2Flocalhost%3A5002/callback" +
                "&state=state-296bc9a0-a2a2-4a57-be1a-d0e2fd9bb601";

            return Redirect(url);
        }
    }
}