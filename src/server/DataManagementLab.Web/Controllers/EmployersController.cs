using DataManagementLab.Domain.Abstractions;
using DataManagementLab.Domain.Entities;
using DataManagementLab.Web.Common;
using Microsoft.AspNetCore.Mvc;

namespace DataManagementLab.Web.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmployersController : CrudControllerBase<Employer>
{
    public EmployersController(IEntityRepository<Employer> entityRepository) 
        : base(entityRepository) {}
}
