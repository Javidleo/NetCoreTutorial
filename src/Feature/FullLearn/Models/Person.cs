﻿namespace FullLearn.Models;

public class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Gender { get; set; }
    public int Age { get; set; }
    public string PhoneNumber { get; set; }

    public ICollection<PersonCourse> PersonCourses { get; set; }
}