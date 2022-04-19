using DataManagementLab.Domain.Abstractions;
using DataManagementLab.Domain.Entities;
using DataManagementLab.Web.Common;
using Microsoft.AspNetCore.Mvc;

namespace DataManagementLab.Web.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ApplicantsController : CrudControllerBase<Applicant>
{
    public ApplicantsController(IEntityRepository<Applicant> entityRepository) 
        : base(entityRepository) {}
}
