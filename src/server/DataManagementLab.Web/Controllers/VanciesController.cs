using AutoMapper;
using DataManagementLab.Application.Models;
using DataManagementLab.Domain.Abstractions;
using DataManagementLab.Domain.Entities;
using DataManagementLab.Web.Common;
using Microsoft.AspNetCore.Mvc;

namespace DataManagementLab.Web.Controllers;

[ApiController]
[Route("api/[controller]")]
public class VacanciesController : CrudControllerBase<Vacancy, VacancyDto>
{
    public VacanciesController(IMapper mapper, IEntityRepository<Vacancy> entityRepository)
        : base(mapper, entityRepository) {}
}
