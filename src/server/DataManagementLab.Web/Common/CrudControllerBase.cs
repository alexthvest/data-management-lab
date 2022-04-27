using System.Text.RegularExpressions;
using AutoMapper;
using DataManagementLab.Domain.Abstractions;
using DataManagementLab.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DataManagementLab.Web.Common;

public abstract class CrudControllerBase<TEntity, TObject> : ControllerBase
    where TEntity : Entity, new()
{
    private readonly IMapper _mapper;
    private readonly IEntityRepository<TEntity> _entityRepository;

    protected CrudControllerBase(IMapper mapper, IEntityRepository<TEntity> entityRepository)
    {
        _mapper = mapper;
        _entityRepository = entityRepository;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<TEntity>>> GetManyEntities(
        [FromQuery] string? range,
        CancellationToken cancellationToken)
    {
        var entities = _entityRepository.Find();

        if (range is not null && Regex.Match(range, @"\[(\d+),(\d+)\]") is { Success: true } match)
        {
            var startIndex = int.Parse(match.Groups[1].Value);
            var endIndex = int.Parse(match.Groups[2].Value);

            entities = entities.Skip(startIndex).Take(endIndex);
        }

        var totalCount = await _entityRepository.CountAsync(cancellationToken);
        HttpContext.Response.Headers["Content-Range"] = totalCount.ToString();

        entities = entities.OrderByDescending(x => x.Id);

        return Ok(entities);
    }

    [HttpGet("{id:int}")]
    public ActionResult<TEntity> GetOneEntity(int id)
    {
        var entity = _entityRepository.FindOne(e => e.Id == id);
        return entity is not null ? Ok(entity) : NotFound(entity);
    }
    
    [HttpPost]
    public virtual async Task<ActionResult<TEntity>> CreateEntity([FromBody] TObject @object, CancellationToken cancellationToken)
    {
        var entity = new TEntity();

        _mapper.Map(@object, entity);
        await _entityRepository.AddAsync(entity, cancellationToken);

        return Created(string.Empty, entity);
    }

    [HttpPut("{id:int}")]
    public async Task<ActionResult<TEntity>> UpdateEntity(int id, [FromBody] TObject @object, CancellationToken cancellationToken)
    {
        var entity = _entityRepository.FindOne(e => e.Id == id);
        if (entity is null)
        {
            return NotFound();
        }

        _mapper.Map(@object, entity);
        await _entityRepository.UpdateAsync(entity, cancellationToken);

        return entity;
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteEntity(int id, CancellationToken cancellationToken)
    {
        var entity = _entityRepository.FindOne(e => e.Id == id);
        if (entity is null)
        {
            return NotFound();
        }

        await _entityRepository.DeleteAsync(entity, cancellationToken);
        return Ok();
    }
}
