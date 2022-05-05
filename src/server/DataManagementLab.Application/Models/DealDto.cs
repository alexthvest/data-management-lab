using System.ComponentModel.DataAnnotations;

namespace DataManagementLab.Application.Models;

public class DealDto
{
    [Required]
    public int ApplicantId { get; set; }
    
    [Required]
    public int VacancyId { get; set; }
    
    [Required]
    public decimal Salary { get; set; }
    
    [Required]
    public decimal Commission { get; set; }
}
