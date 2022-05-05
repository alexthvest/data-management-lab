using System.ComponentModel.DataAnnotations;

namespace DataManagementLab.Application.Models;

public class ApplicantAppointmentDto
{
    [Required]
    public int ApplicantId { get; set; }
    
    [Required]
    public int AppointmentId { get; set; }
}
