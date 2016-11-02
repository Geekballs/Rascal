using System.DirectoryServices.AccountManagement;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.Owin.Security.OAuth;

namespace App.Api.Auth.Lib.Provider
{
    public class AdAuthProvider : OAuthAuthorizationServerProvider
    {
        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext ctx)
        {
            ctx.Validated();
        }

        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext ctx)
        {
            // TODO: Add to AppConfig.
            ctx.OwinContext.Response.Headers.Add("Access-Control-Allow-Origin", new[] { "*" });

#if DEBUG
            const ContextType authType = ContextType.Machine;

#else
            const ContextType authType = ContextType.Domain;
#endif

            var principalCtx = new PrincipalContext(authType);
            var isAuthed = false;
            UserPrincipal userPrincipal = null;

            isAuthed = principalCtx.ValidateCredentials(ctx.UserName, ctx.Password, ContextOptions.Negotiate);
            if (isAuthed)
            {
                //TODO: Add additional security checks.
            }
            else
            {
                ctx.SetError("invalid_grant", "Invalid Credentials!");
                return;
            }

            var identity = new ClaimsIdentity(ctx.Options.AuthenticationType);
            identity.AddClaim(new Claim(ClaimTypes.Role, "user"));
            ctx.Validated(identity);
        }
    }
}