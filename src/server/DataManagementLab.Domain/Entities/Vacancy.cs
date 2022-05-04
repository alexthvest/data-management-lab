namespace DataManagementLab.Domain.Entities;

public class Vacancy : Entity
{
    public int EmployerId { get; set; }

    public int AppointmentId { get; set; }

    public string Description { get; set; } = default!;

    public decimal Salary { get; set; }

    public bool IsOpen { get; set; }
}
