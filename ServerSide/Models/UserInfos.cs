namespace ServerSide.Models;

public class UserInfos
{
    public UserInfos(int id, string userName, int age, string gender)
    {
        Id = id;
        UserName = userName;
        Age = age;
        Gender = gender;
    }

    public int Id { get; set; }
    public string UserName { get; set; }
    public int Age { get; set; }
    public string? Gender { get; set; }
}
