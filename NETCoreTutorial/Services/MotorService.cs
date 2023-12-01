namespace NETCoreTutorial.Services;

public interface IMotorService
{
    void Test();
}
public class MotorService : IMotorService
{
    private readonly ICarService _carService;

    public MotorService(ICarService carService)
    {
        _carService = carService;
    }

    public void Test()
    {
        _carService.NumberOfCars();
    }
}
