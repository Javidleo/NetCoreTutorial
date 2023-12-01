namespace NETCoreTutorial.Common;

public static class Helper
{
    public static ILogger<T> CreateLogger<T>()
    {
        var loggerFactory = LoggerFactory.Create(builder =>
        {
            // Add any desired logging providers here
            builder.AddConsole(); // Example: Log to the console
        });

        // Create an instance of ILogger<T>
        var logger = loggerFactory.CreateLogger<T>();
        return logger;
    }
}
