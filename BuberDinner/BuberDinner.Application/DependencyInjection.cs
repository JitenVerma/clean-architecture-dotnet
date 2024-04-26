using BuberDinner.Application.Services.Authentication;
using BuberDinner.Application.Services.Excel;
using Microsoft.Extensions.DependencyInjection;

namespace BuberDinner.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IAuthenticationService, AuthenticationService>();
        services.AddScoped<ICreateExcelService, CreateExcelService>();
        return services;
    }
}
