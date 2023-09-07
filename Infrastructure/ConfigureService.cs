using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public static class ConfigureService
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            // Configurez l'injection de dépendance ici

            services.AddDbContext<AppDbContext>(options =>
               options.UseSqlServer(configuration.GetConnectionString("localDb"),
                   builder => builder.MigrationsAssembly(typeof(AppDbContext).Assembly.FullName)));


            //services.AddScoped<IAppDbContext>(provider => provider.GetRequiredService<AppDbContext>());

            //services.AddScoped<AppDbContextInitialiser>();


            return services;
        }
    }
}
