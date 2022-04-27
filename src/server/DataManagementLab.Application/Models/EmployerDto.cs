using System.ComponentModel.DataAnnotations;

namespace DataManagementLab.Application.Models;

public class EmployerDto
{
    [Required]
    public string Name { get; set; } = default!;

    [Required]
    public string Address { get; set; } = default!;

    [Required]
    [MaxLength(15)]
    public string Phone { get; set; } = default!;
    
    public int KindOfActivityId { get; set; }
    
    public string? KindOfActivity { get; set; }
}
