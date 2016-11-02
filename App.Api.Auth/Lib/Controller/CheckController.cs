using System.Web.Http;
using App.Api.Auth.Lib.Initialize;

namespace App.Api.Auth.Lib.Controller
{
    [RoutePrefix("api/check")]
    public class CheckController : ApiController
    {
        [Route("app"), HttpGet]
        public IHttpActionResult App()
        {
            return Ok("Howdy from " + AppConfig.AppName + "!");
        }

        [Route("auth"), HttpGet, Authorize]
        public IHttpActionResult Auth()
        {
            return Ok("Howdy from authenticated " + AppConfig.AppName + "!");
        }

        // TODO: Add authorization check.
    }
}
