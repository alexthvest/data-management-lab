using AutoMapper;
using DataManagementLab.Application.Models;
using DataManagementLab.Domain.Abstractions;
using DataManagementLab.Domain.Entities;
using DataManagementLab.Web.Common;
using Microsoft.AspNetCore.Mvc;

namespace DataManagementLab.Web.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ApplicantAppointmentsController : CrudControllerBase<ApplicantAppointment, ApplicantAppointmentDto>
{
    public ApplicantAppointmentsController(IMapper mapper, IEntityRepository<ApplicantAppointment> entityRepository) 
        : base(mapper, entityRepository) {}
}
