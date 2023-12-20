namespace Server.Models;

public class UserInfo
{
    public UserInfo(int id, string name, string family)
    {
        Id = id;
        Name = name;
        Family = family;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public string Family { get; set; }
}
