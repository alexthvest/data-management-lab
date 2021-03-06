namespace DataManagementLab.Domain.Entities;

public class Applicant : Entity
{
    public string FirstName { get; set; } = default!;
    
    public string LastName { get; set; } = default!;
    
    public string? Surname { get; set; }
    
    public string? OtherData { get; set; }
}
