using System.Web.Http;

namespace App.Api.Auth.Lib.Controller
{
    [RoutePrefix("api/check")]
    public class CheckController : ApiController
    {
        [Route("app"), HttpGet]
        public IHttpActionResult App()
        {
            return Ok("Hello World!");
        }

        [Route("auth"), HttpGet, Authorize]
        public IHttpActionResult Auth()
        {
            return Ok("Hello Authenticated World!");
        }

        // TODO: Add authorization check.
    }
}
