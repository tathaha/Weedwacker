﻿using Microsoft.AspNetCore.Http;

namespace Weedwacker.WebServer.Handlers
{
    internal class SdkDataUpload : IHandler
    {
        public class SdkDataUploadResJson
        {
            public int code { get; set; } = 0;
        }

        public async Task<bool> HandleAsync(HttpContext context)
        {
            await context.Response.WriteAsJsonAsync(new SdkDataUploadResJson());
            return true;
        }
    }
}
