namespace FullLearn.Services;

public interface IDiServeses
{
    string ShowUser(string username, int age);
}
public class DiServeses : IDiServeses
{
    public string ShowUser (string username, int age)
    {
        return $"{username} , and {age} years old.";
    }
}
