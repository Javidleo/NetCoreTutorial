namespace FullLearn.Models;

public class PersonCourse
{
    public int Id { get; set; }
    public int PersonId { get; set; }
    public Person Person { get; set; }
    public int CourseId { get; set; }
    public Courses Courses { get; set; }
}
