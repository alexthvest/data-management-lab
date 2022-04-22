using System.ComponentModel.DataAnnotations;

namespace DataManagementLab.Application.Models;

public class AppointmentDto
{
    [Required]
    public string Title { get; set; } = default!;
}
