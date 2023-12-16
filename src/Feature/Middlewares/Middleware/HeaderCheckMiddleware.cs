using Middlewares.Common;
using Middlewares.Controllers;

namespace Middlewares.Middleware;
public class HeaderCheckMiddleware
{
    private readonly RequestDelegate _next;

    public HeaderCheckMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext httpContext)
    {
        if (httpContext.Request.Headers.DoesHaveRezaHeader() is false)  
        {
            await httpContext.WriteError("this request does not have reza header", 401);
            return;
        }

        await _next(httpContext);
    }
}
// Extension method used to add the middleware to the HTTP request pipeline.
public static class TestMiddlewareExtensions
{
    public static IApplicationBuilder UseTestMiddleware(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<HeaderCheckMiddleware>();
    }
}
