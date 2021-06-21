using EFCore.WebAPI.Application.Interfaces;
using EFCore.WebAPI.Domain.Settings;
using EFCore.WebAPI.Infrastructure.Shared.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EFCore.WebAPI.Infrastructure.Shared
{
    public static class ServiceRegistration
    {
        public static void AddSharedInfrastructure(this IServiceCollection services, IConfiguration _config)
        {
            services.Configure<MailSettings>(_config.GetSection("MailSettings"));
            services.AddTransient<IDateTimeService, DateTimeService>();
            services.AddTransient<IEmailService, EmailService>();
        }
    }
}
