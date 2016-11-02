using System;
using System.Configuration;

namespace App.Api.Auth.Lib.Initialize
{
    public static class AppConfig
    {
        public static readonly bool AllowInsecureHttp = Convert.ToBoolean(ConfigurationManager.AppSettings["app:AllowInsecureHttp"]);
        public static readonly string TokenEndpointPath = ConfigurationManager.AppSettings["app:TokenEndpointPath"];
        public static readonly int AccessTokenExpireTimeSpan = Convert.ToInt32(ConfigurationManager.AppSettings["app:AccessTokenExpireTimeSpan"]);
        public static readonly string AppName = ConfigurationManager.AppSettings["brand:AppName"];
        public static readonly string AppVersion = ConfigurationManager.AppSettings["brand:AppVersion"];
        public static readonly string AppEnvironment = ConfigurationManager.AppSettings["brand:AppEnvironment"];
        public static readonly string CompanyName = ConfigurationManager.AppSettings["brand:CompanyName"];
    }
}