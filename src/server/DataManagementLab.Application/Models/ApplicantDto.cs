using System.ComponentModel.DataAnnotations;

namespace DataManagementLab.Application.Models;

public class ApplicantDto
{
    [Required]
    public string FirstName { get; set; } = default!;

    [Required]
    public string LastName { get; set; } = default!;

    public string? Surname { get; set; }

    public string? OtherData { get; set; }
}
