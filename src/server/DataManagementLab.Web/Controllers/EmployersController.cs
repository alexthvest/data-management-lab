using AutoMapper;
using DataManagementLab.Application.Models;
using DataManagementLab.Domain.Abstractions;
using DataManagementLab.Domain.Entities;
using DataManagementLab.Web.Common;
using Microsoft.AspNetCore.Mvc;

namespace DataManagementLab.Web.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmployersController : CrudControllerBase<Employer, EmployerDto>
{
    public EmployersController(IMapper mapper, IEntityRepository<Employer> entityRepository) 
        : base(mapper, entityRepository) {}
}
