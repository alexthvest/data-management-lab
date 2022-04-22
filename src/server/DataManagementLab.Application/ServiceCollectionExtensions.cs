using DataManagementLab.Application.Models;
using DataManagementLab.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;

namespace DataManagementLab.Application;

public static class ServiceCollectionExtensions
{
    public static void AddApplication(this IServiceCollection services)
    {
        services.AddAutoMapper(c =>
        {
            c.CreateMap<EmployerDto, Employer>();
            c.CreateMap<ApplicantDto, Applicant>();
            c.CreateMap<KindOfActivityDto, KindOfActivity>();
            c.CreateMap<AppointmentDto, Appointment>();
        });
    }
}
