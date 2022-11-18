namespace UniversityApiBackend.Models.DataModels;

public class BaseEntity
{
    public int Id { get; set; }

    public string CreatedBy { get; set; } = null!;
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public string? LastModifiedBy { get; set; } = null;
    public DateTime? LastModified { get; set; } = null;
    public string? DeletedBy { get; set; } = null;
    public DateTime? DeletedAt { get; set; } = null;
    public bool IsDeleted { get; set; } = false;

}
