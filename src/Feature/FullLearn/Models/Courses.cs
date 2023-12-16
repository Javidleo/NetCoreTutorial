namespace FullLearn.Models;

public class Courses
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public ICollection<PersonCourse> PersonCourses { get; set; }
}