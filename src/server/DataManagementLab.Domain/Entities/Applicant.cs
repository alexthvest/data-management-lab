using System.ComponentModel.DataAnnotations.Schema;

namespace DataManagementLab.Domain.Entities;

public class Applicant : Entity
{
    [Column(TypeName = "nvarchar(50)")]
    public string FirstName { get; set; } = default!;
    
    [Column(TypeName = "nvarchar(50)")]
    public string LastName { get; set; } = default!;
    
    [Column(TypeName = "nvarchar(50)")]
    public string? Surname { get; set; }
    
    [Column(TypeName = "nvarchar(-1)")]
    public string? OtherData { get; set; }
}
