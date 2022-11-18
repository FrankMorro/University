namespace UniversityApiBackend.Models.DataModels;

public class BaseEntity
{
  public int Id { get; set; }

  public int UserID { get; set; }

  public virtual User CreatedBy { get; set; } = new User();
  public DateTime CreatedAt { get; set; } = DateTime.Now;
  public virtual User? LastModifiedBy { get; set; } = new User();
  public DateTime? LastModified { get; set; } = null;
  public virtual User? DeletedBy { get; set; } = new User();
  public DateTime? DeletedAt { get; set; } = null;
  public bool IsDeleted { get; set; } = false;

}
