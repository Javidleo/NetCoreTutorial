using FullLearn.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FullLearn.Prestence.Mapping;

public class PersonCourseMapping : IEntityTypeConfiguration<PersonCourse>
{
    public void Configure(EntityTypeBuilder<PersonCourse> builder)
    {
        builder.HasOne(i => i.Person)
            .WithMany(i => i.PersonCourses)
            .HasForeignKey(i => i.PersonId);

        builder.HasOne(i => i.Courses)
            .WithMany(i => i.PersonCourses)
            .HasForeignKey(i => i.CourseId);
    }
}
