using FullLearn.Common;

namespace FullLearn.MiddleWare;

public class ErrorHandlerMiddleWare
{
    private readonly RequestDelegate _next;

    public ErrorHandlerMiddleWare(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception ex)
        {
            var error = new Error(DateTime.Now, ex.Message, 500);
            await context.ErrorHandler(error);
            return;
        }
    }
}

public static class ErrorHandlerExtention
{
    public static IApplicationBuilder UseErrorHandler (this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<ErrorHandlerMiddleWare>(); 
    }
}
