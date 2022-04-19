using System.Linq.Expressions;
using DataManagementLab.Domain.Entities;

namespace DataManagementLab.Domain.Abstractions;

public interface IEntityRepository<TEntity>
    where TEntity : Entity
{
    Task<TEntity> AddAsync(TEntity entity, CancellationToken cancellationToken = default);

    IQueryable<TEntity> Find();

    IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

    TEntity? FindOne(Expression<Func<TEntity, bool>> predicate);

    Task<TEntity> UpdateAsync(TEntity entity, CancellationToken cancellationToken = default);

    Task<int> CountAsync(CancellationToken cancellationToken = default);
}
