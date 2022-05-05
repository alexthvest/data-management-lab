using AutoMapper;
using DataManagementLab.Application.Models;
using DataManagementLab.Domain.Abstractions;
using DataManagementLab.Domain.Entities;
using DataManagementLab.Web.Common;
using Microsoft.AspNetCore.Mvc;

namespace DataManagementLab.Web.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DealsController : CrudControllerBase<Deal, DealDto>
{
    public DealsController(IMapper mapper, IEntityRepository<Deal> entityRepository)
        : base(mapper, entityRepository) {}
}
