using System.ComponentModel.DataAnnotations;

namespace UniversityApiBackend.Models.DataModels;

public class Student : BaseEntity
{
  private int _edad;

  [Required, StringLength(50)]
  public string Nombre { get; set; } = null!;

  [Required, StringLength(50)]
  public string Apellido { get; set; } = null!;

  [Required]
  public DateTime FechaNacimiento { get; set; }

  [Required, EmailAddress, StringLength(100)]
  public string Email { get; set; } = null!;

  public int Edad
  {
    get
    {
      if (_edad <= 0)
      {
        _edad = new DateTime(DateTime.Now.Subtract(FechaNacimiento).Ticks).Year - 1;
      }
      return _edad;
    }
  }

  // Relaciones de Tabla
  public ICollection<Course> Courses { get; set; } = new List<Course>();


}
