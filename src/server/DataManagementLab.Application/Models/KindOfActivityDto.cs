using System.ComponentModel.DataAnnotations;

namespace DataManagementLab.Application.Models;

public class KindOfActivityDto
{
    [Required]
    public string Title { get; set; } = default!;
}
