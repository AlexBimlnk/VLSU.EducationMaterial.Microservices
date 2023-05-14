using MicroserviceStudent.Models;
using Microsoft.EntityFrameworkCore;

namespace MicroserviceStudent;

public class StudentContext : DbContext
{
    public StudentContext(DbContextOptions<StudentContext> options)
        : base(options)
    {
    }

    public DbSet<Student> Students { get; set; }
}