using System.ComponentModel.DataAnnotations.Schema;

namespace DataManagementLab.Domain.Entities;

public class KindOfActivity : Entity
{
    [Column(TypeName = "nvarchar(255)")]
    public string Title { get; set; } = default!;
}
