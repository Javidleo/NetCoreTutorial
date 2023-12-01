namespace NETCoreTutorial.Services;

public interface IBusServices
{
    Task<string> Test();
    Task<string> Test2();

}

public class MiniBusService : IBusServices
{
    private readonly ILogger<MiniBusService> _logger;
    private readonly ICarService _carService;
    public MiniBusService(ILogger<MiniBusService> logger, ICarService carService)
    {
        _logger = logger;
        _carService = carService;
    }

    public async Task<string> Test()
    {
        _logger.LogInformation("its a new log for bus");
        var number = await _carService.NumberOfCars();
        return "Test";
    }

    public async Task<string> Test2()
    {
        _logger.LogInformation("its a new log for bus");
        var number = await _carService.NumberOfCars();
        return $"Test {number}";
    }
}

