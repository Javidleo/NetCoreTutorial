using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace FullLearn.Common;

public static class ErrorExtention
{
    public static async Task ErrorHandler(this HttpContext context , Error error)
    {
        context.Response.StatusCode = error.StatusCode;
        context.Response.Headers.Add("Content-Type", "application/json");

        await context.Response.WriteAsync(JsonConvert.SerializeObject(error));
    }
}
