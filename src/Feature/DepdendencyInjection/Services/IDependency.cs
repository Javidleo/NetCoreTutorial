namespace DepdendencyInjection.Services
{
    public interface IDependency
    {
        string Test(string name);

    }
    public class NewDpendency : IDependency
    {
        public string Test(string name)
        {
            return  $"My Name is {name}";
        }
    }
}
