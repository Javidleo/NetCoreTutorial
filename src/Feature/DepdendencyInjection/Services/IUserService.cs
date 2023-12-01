namespace DepdendencyInjection.Services;

public interface IUserService
{
    string AddUser(string name, string password);
}
public class UserService : IUserService
{
    private readonly ILogService _logService;

    public UserService(ILogService logService)
    {
        _logService = logService;
    }

    public string AddUser(string name, string password)
    {
        _logService.TestLog();

        return $"user :{name} added";
    }
}
