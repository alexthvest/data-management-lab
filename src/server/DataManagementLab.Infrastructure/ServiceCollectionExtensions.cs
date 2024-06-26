﻿using DataManagementLab.Domain.Abstractions;
using DataManagementLab.Domain.Repositories;
using DataManagementLab.Infrastructure.Data;
using DataManagementLab.Infrastructure.Data.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DataManagementLab.Infrastructure;

public static class ServiceCollectionExtensions
{
    public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddSqlServer<ApplicationDbContext>(
            configuration.GetConnectionString("DefaultConnection"));

        services.AddScoped(typeof(IEntityRepository<>), typeof(EntityRepository<>));
        services.AddScoped<IEmployerRepository, EmployerRepository>();
    }
}