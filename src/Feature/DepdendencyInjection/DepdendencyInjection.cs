using DepdendencyInjection.Services;

namespace DepdendencyInjection;

public static class DepdendencyInjection
{
    public static IServiceCollection AddCustomServices(this IServiceCollection services)
    {
        services.AddTransient<IUserService, UserService>();
        services.AddTransient<ILogService, LogService>();
        services.AddTransient<IDependency, NewDpendency>();
        services.AddScoped<IShowFamilyName , ShowFamilyName>();

        //services.AddScoped<ILogService, LogService>();
        //services.AddSingleton<ILogService, LogService>();

        return services;
    }
}
