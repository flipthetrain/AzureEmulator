using Microsoft.AspNetCore.Http;

namespace AzureEmulator.MVC.Middleware
{
    public class CaptureAll
    {
        private readonly RequestDelegate _next;
        public CaptureAll(RequestDelegate next)
        {
            _next = next;
        }
        public async void Invoke(HttpContext context)
        {
            await _next(context);
        }
    }
}
