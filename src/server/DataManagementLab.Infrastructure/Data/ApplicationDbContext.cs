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

    public DbSet<Vacancy> Vacancies => Set<Vacancy>();
    
    public DbSet<Deal> Deals => Set<Deal>();

    public DbSet<ApplicantAppointment> ApplicantAppointments => Set<ApplicantAppointment>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Employer>().ToTable("Employer");
        modelBuilder.Entity<Applicant>().ToTable("Applicant");
        modelBuilder.Entity<KindOfActivity>().ToTable("KindOfActivity");
        modelBuilder.Entity<Appointment>().ToTable("Appointment");
        modelBuilder.Entity<Vacancy>().ToTable("Vacancy");
        modelBuilder.Entity<Deal>().ToTable("Deal");
        modelBuilder.Entity<ApplicantAppointment>().ToTable("ApplicantAppointment");
    }
}
