namespace NETCoreTutorial.Services;

public interface ICarService
{
    Task<int> NumberOfCars();
}
public class CarService : ICarService
{
    private readonly ILogger<CarService> _logger;
    private string result = "empty";
    public CarService(ILogger<CarService> logger)
    {
        _logger = logger;
    }

    public Task<int> NumberOfCars()
    {
        _logger.LogInformation($"test is: {result}");

        result = "new test";
        return Task.FromResult(10);
    }
}
