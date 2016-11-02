using System.Net.Http.Formatting;
using System.Web;
using System.Web.Http;
using App.Api.Auth.Lib.Initialize;

namespace App.Api.Auth
{
    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}