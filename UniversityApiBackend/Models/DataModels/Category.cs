using System.ComponentModel.DataAnnotations;

namespace UniversityApiBackend.Models.DataModels;

public class Category : BaseEntity
{
  [Required, StringLength(50)]
  public string Name { get; set; } = null!;

  public ICollection<Course> Courses { get; set; } = new List<Course>();

}
