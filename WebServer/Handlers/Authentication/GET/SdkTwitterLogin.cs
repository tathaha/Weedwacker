﻿using Microsoft.AspNetCore.Http;
using Weedwacker.WebServer.Authentication;
using static Weedwacker.WebServer.Authentication.IOAuthAuthenticator;

namespace Weedwacker.WebServer.Handlers
{
    internal class SdkTwitterLogin : IHandler
    {
        public async Task<bool> HandleAsync(HttpContext context)
        {
            await WebServer.AuthenticationSystem.GetOAuthAuthenticator()
                .HandleRedirection(IAuthenticationSystem.FromExternalRequest(context), ClientType.MOBILE);
            return true;
        }
    }
}
