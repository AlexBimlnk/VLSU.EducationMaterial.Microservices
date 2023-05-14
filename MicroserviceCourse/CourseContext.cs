using MicroserviceCourse.Models;
using Microsoft.EntityFrameworkCore;

namespace MicroserviceCourse;

public class CourseContext : DbContext
{
    public CourseContext(DbContextOptions<CourseContext> options)
        : base(options)
    {
    }

    public DbSet<Course> Courses { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Course>(entity =>
        {
            entity
                .ToTable("courses")
                .HasKey(e => e.Id);

            entity
                .Property(e => e.Id)
                .HasColumnName("id");

            entity
                .Property(e => e.Name)
                .HasColumnName("name");

            entity
                .Property(e => e.Disciplenes)
                .HasColumnName("disciplenes");
        });
    }

}
