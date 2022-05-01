using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Clinical_Trials_Adverse_Events_Reporting_System.Utilities
{
    public class WebAppAuthStateProvider : AuthenticationStateProvider
    {
        public override Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var randomPrincipal = new ClaimsPrincipal();
            var identity = new ClaimsIdentity();
            identity.AddClaim(new Claim(ClaimTypes.Name, "Armin"));
            identity.AddClaim(new Claim(ClaimTypes.Role, "CRO"));
            randomPrincipal.AddIdentity(identity);
            return Task.FromResult(new AuthenticationState(randomPrincipal));
        }

    }
}
