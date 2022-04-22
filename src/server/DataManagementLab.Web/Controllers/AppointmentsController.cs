using AutoMapper;
using DataManagementLab.Application.Models;
using DataManagementLab.Domain.Abstractions;
using DataManagementLab.Domain.Entities;
using DataManagementLab.Web.Common;
using Microsoft.AspNetCore.Mvc;

namespace DataManagementLab.Web.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AppointmentsController : CrudControllerBase<Appointment, AppointmentDto>
{
    public AppointmentsController(IMapper mapper, IEntityRepository<Appointment> entityRepository) 
        : base(mapper, entityRepository) {}
}
