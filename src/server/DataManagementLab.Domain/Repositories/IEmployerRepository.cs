using DataManagementLab.Domain.Abstractions;
using DataManagementLab.Domain.Entities;

namespace DataManagementLab.Domain.Repositories;

public interface IEmployerRepository : IEntityRepository<Employer>
{
    Task<Employer> AddAsync(string name, string address, string phone, string kindOfActivity, CancellationToken cancellationToken = default);
}
