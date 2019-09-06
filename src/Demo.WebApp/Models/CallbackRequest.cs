using Microsoft.AspNetCore.Mvc;

namespace Demo.WebApp.Models
{
    public class CallbackRequest
    {
        [FromQuery(Name = "code")]
        public string Code { get; set; }

        [FromQuery(Name = "scope")]
        public string Scope { get; set; }

        [FromQuery(Name = "state")]
        public string State { get; set; }

        [FromQuery(Name = "session_state")]
        public string SessionState { get; set; }
    }
}