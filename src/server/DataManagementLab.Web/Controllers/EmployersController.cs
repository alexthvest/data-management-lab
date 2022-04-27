using AutoMapper;
using DataManagementLab.Application.Models;
using DataManagementLab.Domain.Entities;
using DataManagementLab.Domain.Repositories;
using DataManagementLab.Web.Common;
using Microsoft.AspNetCore.Mvc;

namespace DataManagementLab.Web.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmployersController : CrudControllerBase<Employer, EmployerDto>
{
    private readonly IMapper _mapper;
    private readonly IEmployerRepository _entityRepository;

    public EmployersController(IMapper mapper, IEmployerRepository entityRepository)
        : base(mapper, entityRepository)
    {
        _mapper = mapper;
        _entityRepository = entityRepository;
    }

    [HttpPost]
    public override async Task<ActionResult<Employer>> CreateEntity(EmployerDto @object, CancellationToken cancellationToken)
    {
        var entity = new Employer();

        var employer = new Employer
        {
            Name = "alexthvest"
        };

        if (string.IsNullOrEmpty(@object.KindOfActivity))
        {
            _mapper.Map(@object, entity);
            await _entityRepository.AddAsync(entity, cancellationToken);
        }
        else
        {
            entity = await _entityRepository.AddAsync(@object.Name, @object.Address,
                @object.Phone, @object.KindOfActivity, cancellationToken);
        }

        return Created(string.Empty, entity);
    }
}
