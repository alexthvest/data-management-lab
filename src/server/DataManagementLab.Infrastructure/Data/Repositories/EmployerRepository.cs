using System.Data;
using DataManagementLab.Domain.Entities;
using DataManagementLab.Domain.Repositories;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace DataManagementLab.Infrastructure.Data.Repositories;

internal class EmployerRepository : EntityRepository<Employer>, IEmployerRepository
{
    private readonly ApplicationDbContext _dbContext;

    public EmployerRepository(ApplicationDbContext dbContext)
        : base(dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Employer> AddAsync(string name, string address, string phone, string kindOfActivity, CancellationToken cancellationToken = default)
    {
        var employerId = new SqlParameter("@Id", SqlDbType.Int)
        {
            Direction = ParameterDirection.Output
        };

        var kindOfActivityId = new SqlParameter("@KindOfActivityId", SqlDbType.Int)
        {
            Direction = ParameterDirection.Output
        };
        
        await _dbContext.Database.ExecuteSqlRawAsync(
            "EXEC InsertEmployer @Name, @Address, @Phone, @KindOfActivity, @Id OUT, @KindOfActivityId OUT",
            new SqlParameter("@Name", name),
            new SqlParameter("@Address", address),
            new SqlParameter("@Phone", phone),
            new SqlParameter("@KindOfActivity", kindOfActivity),
            employerId, 
            kindOfActivityId
        );

        await _dbContext.SaveChangesAsync(cancellationToken);

        return new Employer
        {
            Id = Convert.ToInt32(employerId.Value),
            KindOfActivityId = Convert.ToInt32(kindOfActivityId.Value)
        };
    }
}
