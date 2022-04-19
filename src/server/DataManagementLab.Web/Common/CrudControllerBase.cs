using System.Text.RegularExpressions;
using DataManagementLab.Domain.Abstractions;
using DataManagementLab.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DataManagementLab.Web.Common;

public abstract class CrudControllerBase<TEntity> : ControllerBase
    where TEntity : Entity
{
    private readonly IEntityRepository<TEntity> _entityRepository;

    protected CrudControllerBase(IEntityRepository<TEntity> entityRepository)
    {
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
        
        return Ok(entities);
    }

    [HttpGet("{id:int}")]
    public ActionResult<TEntity> GetOneEntity(int id)
    {
        var entity = _entityRepository.FindOne(e => e.Id == id);
        return entity is not null ? Ok(entity) : NotFound(entity);
    }
}
