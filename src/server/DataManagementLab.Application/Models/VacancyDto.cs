using System.ComponentModel.DataAnnotations;

namespace DataManagementLab.Application.Models;

public class VacancyDto
{
    [Required]
    public int EmployerId { get; set; }

    [Required]
    public int AppointmentId { get; set; }

    public string? Description { get; set; }

    [Required]
    public decimal Salary { get; set; }

    public bool IsOpen { get; set; }
}
