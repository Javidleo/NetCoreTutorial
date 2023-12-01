namespace DepdendencyInjection.Services;

public interface ILogService
{
    void TestLog();
}

public class LogService : ILogService
{
    private readonly ILogger<LogService> _logger;
    private string _loggerMessage = "emptyMessageForFirstTime";
    public LogService(ILogger<LogService> logger)
    {
        _logger = logger;
    }

    public void TestLog()
    {
        _logger.LogInformation($"its the log message : {_loggerMessage}");
    }
}

