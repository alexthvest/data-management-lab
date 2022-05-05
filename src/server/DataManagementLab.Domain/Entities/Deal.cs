namespace DataManagementLab.Domain.Entities;

public class Deal : Entity
{
    public int ApplicantId { get; set; }
    
    public int VacancyId { get; set; }
    
    public decimal Salary { get; set; }
    
    public decimal Commission { get; set; }
}
