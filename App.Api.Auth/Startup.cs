﻿using System;
using System.Web.Http;
using App.Api.Auth.Lib.Initialize;
using App.Api.Auth.Lib.Provider;
using Microsoft.Owin;
using Microsoft.Owin.Security.OAuth;
using Owin;

namespace App.Api.Auth
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();
            ConfigureOAuth(app);
            WebApiConfig.Register(config);
            app.UseWebApi(config);
        }

        public void ConfigureOAuth(IAppBuilder app)
        {
            var oAuthServerOptions = new OAuthAuthorizationServerOptions()
            {
                AllowInsecureHttp = AppConfig.AllowInsecureHttp,
                TokenEndpointPath = new PathString(AppConfig.TokenEndpointPath),
                AccessTokenExpireTimeSpan = TimeSpan.FromMinutes(AppConfig.AccessTokenExpireTimeSpan),
                Provider = new AdAuthProvider()
            };
            app.UseOAuthAuthorizationServer(oAuthServerOptions);
            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());
        }
    }
}