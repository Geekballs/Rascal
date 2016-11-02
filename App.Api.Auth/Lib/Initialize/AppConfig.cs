using System;
using System.Configuration;

namespace App.Api.Auth.Lib.Initialize
{
    public class AppConfig
    {
        public static readonly string AppName = ConfigurationManager.AppSettings["brand:AppName"];
        public static readonly string AppVersion = ConfigurationManager.AppSettings["brand:AppVersion"];
        public static readonly string AppEnvironment = ConfigurationManager.AppSettings["brand:AppEnvironment"];
        public static readonly string CompanyName = ConfigurationManager.AppSettings["brand:CompanyName"];
    }
}