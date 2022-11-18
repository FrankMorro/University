using Microsoft.EntityFrameworkCore;
using UniversityApiBackend.Models.DataModels;

namespace UniversityApiBackend.DataAccess;

public class UniversityDBContext : DbContext
{
  public UniversityDBContext(DbContextOptions<UniversityDBContext> options) : base(options)
  {

  }

  // TODO: Add DbSets (Tablas de la Base de datos)
  public DbSet<User>? Users { get; set; }
  public DbSet<Course>? Courses { get; set; }
  public DbSet<Chapter>? Chapters { get; set; }
  public DbSet<Category>? Categories { get; set; }
  public DbSet<Student>? Students { get; set; }
}
