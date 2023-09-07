using System.Reflection;
using Application.Products.Commands;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

public static class ConfigureServices
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        // Enregistrez les validateurs FluentValidation depuis l'assembly en cours
        services.AddMediatR(cfg =>
        {
            cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());

        });
            return services;
    }
}
