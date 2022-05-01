using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Scope.AspNetCore
{
    public class WebAppAuthHandler : IAuthenticationHandler
    {
        private AuthenticationScheme _authScheme = null;
        private HttpContext _httpContext = null;
        public WebAppAuthHandler()
        {
           
        }

        public Task<AuthenticateResult> AuthenticateAsync()
        {
            return Task.Run<AuthenticateResult>(() =>
            {
                var principal = _httpContext.User;
                if(principal == default)
                {
                    return AuthenticateResult.Fail(new UnauthorizedAccessException());
                }
                else
                {
                    return AuthenticateResult.Success(new AuthenticationTicket(principal, _authScheme.Name ?? "ScopeWebAppAuth"));
                }
            });
        }

        public Task ChallengeAsync(AuthenticationProperties properties)
        {
            throw new NotImplementedException();
        }

        public Task ForbidAsync(AuthenticationProperties properties)
        {
            return Task.Run(() =>
            {
                _httpContext.Response.StatusCode = StatusCodes.Status403Forbidden;
            });
        }

        public Task InitializeAsync(AuthenticationScheme scheme, HttpContext context)
        {
            return Task.Run(() => {
                _httpContext = context;
                _authScheme = scheme;
            });
        }
    }
}
