namespace DataManagementLab.Domain.Entities;

public class Employer : Entity
{
    public string Name { get; set; } = default!;

    public string Address { get; set; } = default!;

    public string Phone { get; set; } = default!;
    
    public int KindOfActivityId { get; set; }
}
