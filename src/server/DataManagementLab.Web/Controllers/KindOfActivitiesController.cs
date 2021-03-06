using AutoMapper;
using DataManagementLab.Application.Models;
using DataManagementLab.Domain.Abstractions;
using DataManagementLab.Domain.Entities;
using DataManagementLab.Web.Common;
using Microsoft.AspNetCore.Mvc;

namespace DataManagementLab.Web.Controllers;

[ApiController]
[Route("api/[controller]")]
public class KindOfActivitiesController : CrudControllerBase<KindOfActivity, KindOfActivityDto>
{
    public KindOfActivitiesController(IMapper mapper, IEntityRepository<KindOfActivity> entityRepository) 
        : base(mapper, entityRepository) {}
}
