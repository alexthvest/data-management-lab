using System.ComponentModel.DataAnnotations.Schema;

namespace DataManagementLab.Domain.Entities;

public class Employer : Entity
{
    [Column(TypeName = "nvarchar(65)")]
    public string? Name { get; set; }
    
    [Column(TypeName = "nvarchar(255)")]
    public string? Address { get; set; }
    
    [Column(TypeName = "nvarchar(15)")]
    public string? Phone { get; set; }
}
