using DataManagementLab.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataManagementLab.Infrastructure.Data;

internal class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) {}

    public DbSet<Employer> Employers => Set<Employer>();
    
    public DbSet<Applicant> Applicants => Set<Applicant>();

    public DbSet<KindOfActivity> KindOfActivities => Set<KindOfActivity>();
}
