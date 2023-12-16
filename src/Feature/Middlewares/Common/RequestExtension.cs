using Microsoft.AspNetCore.Diagnostics;
using Newtonsoft.Json;

namespace Middlewares.Common;

public static class RequestExtension
{
    public static async Task WriteError(this HttpContext httpContext, object error, int statusCode)
    {
        httpContext.Response.StatusCode = statusCode;
        httpContext.Response.Headers.Add("Content-Type", "application/json");

        await httpContext.Response.WriteAsync(JsonConvert.SerializeObject(error));
    }


    public static bool DoesHaveRezaHeader(this IHeaderDictionary header)
    {
        var value = header.FirstOrDefault(i => i.Key == "is_reza");

        if (value!.Value.Contains("123") is false)
        {
            return false;
        }

        return true;
    }

}