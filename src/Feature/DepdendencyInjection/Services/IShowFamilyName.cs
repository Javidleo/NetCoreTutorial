namespace DepdendencyInjection.Services
{
    public interface IShowFamilyName
    {
        string Id(string Fnam);
    }
    public class ShowFamilyName : IShowFamilyName
    {
        public string Id(string Fname) 
        { 
            return $"This is your First Name {Fname}";
        }
    }
}
