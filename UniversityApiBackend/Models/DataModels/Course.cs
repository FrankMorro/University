using System.ComponentModel.DataAnnotations;

namespace UniversityApiBackend.Models.DataModels;

public enum Level
{
  Basico,
  Medio,
  Avanzado,
  Experto
}

public class Course : BaseEntity
{
  [Required, StringLength(50)]
  public string Name { get; set; } = null!;

  [Required, StringLength(100)]
  public string Description { get; set; } = null!;

  [Required, StringLength(500)]
  public string? DescripcionLarga { get; set; } = null;

  [Required]
  public Level Level { get; set; } = Level.Basico;

  // Construimos las Relaciones
  [Required]
  public ICollection<Category> Categories { get; set; } = new List<Category>();

  [Required]
  public ICollection<Student> Students { get; set; } = new List<Student>();

  public Chapter Chapter { get; set; } = new Chapter();
}
