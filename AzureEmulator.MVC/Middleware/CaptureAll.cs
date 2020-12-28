using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace AzureEmulator.MVC.Middleware
{
    public class CaptureAll
    {
        private readonly RequestDelegate _next;
        public CaptureAll(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            await _next(context);
        }
    }
}
