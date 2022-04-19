using System.Linq.Expressions;
using DataManagementLab.Domain.Abstractions;
using DataManagementLab.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataManagementLab.Infrastructure.Data;

internal class EntityRepository<TEntity> : IEntityRepository<TEntity>
    where TEntity : Entity
{
    private readonly ApplicationDbContext _dbContext;

    public EntityRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<TEntity> AddAsync(TEntity entity, CancellationToken cancellationToken = default)
    {
        await _dbContext.AddAsync(entity, cancellationToken);
        await _dbContext.SaveChangesAsync(cancellationToken);
        return entity;
    }

    public IQueryable<TEntity> Find()
    {
        return _dbContext.Set<TEntity>().AsNoTracking();
    }

    public IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
    {
        return _dbContext.Set<TEntity>().Where(predicate).AsNoTracking();
    }

    public TEntity? FindOne(Expression<Func<TEntity, bool>> predicate)
    {
        return _dbContext.Set<TEntity>().FirstOrDefault(predicate);
    }

    public async Task<TEntity> UpdateAsync(TEntity entity, CancellationToken cancellationToken = default)
    {
        _dbContext.Update(entity);
        await _dbContext.SaveChangesAsync(cancellationToken);
        return entity;
    }

    public Task<int> CountAsync(CancellationToken cancellationToken = default)
    {
        return _dbContext.Set<TEntity>().CountAsync(cancellationToken);
    }
}
