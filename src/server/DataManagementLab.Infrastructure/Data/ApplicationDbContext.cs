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
    
    public DbSet<Appointment> Appointments => Set<Appointment>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Employer>()
            .ToTable("Employer");
        
        modelBuilder.Entity<Applicant>()
            .ToTable("Applicant");
        
        modelBuilder.Entity<KindOfActivity>()
            .ToTable("KindOfActivity");
        
        modelBuilder.Entity<Appointment>()
            .ToTable("Appointment");
    }
}
