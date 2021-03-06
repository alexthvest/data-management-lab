using AutoMapper;
using DataManagementLab.Application.Models;
using DataManagementLab.Domain.Abstractions;
using DataManagementLab.Domain.Entities;
using DataManagementLab.Web.Common;
using Microsoft.AspNetCore.Mvc;

namespace DataManagementLab.Web.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ApplicantsController : CrudControllerBase<Applicant, ApplicantDto>
{
    public ApplicantsController(IMapper mapper, IEntityRepository<Applicant> entityRepository) 
        : base(mapper, entityRepository) {}
}
