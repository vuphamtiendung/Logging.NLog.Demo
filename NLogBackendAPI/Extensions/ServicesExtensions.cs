using LoggingService;

namespace NLogBackendAPI.Extensions
{
    public static class ServicesExtensions
    {
        public static void ConfigurationCors(this IServiceCollection service)
        {
            service.AddCors(option =>
            {
                option.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader());
            });
        }

        public static void ConfigurationIISIntegration(this IServiceCollection service)
        {
            service.Configure<IISOptions>(option =>
            {
            });
        }

        public static void ConfigurationNlogServices(this IServiceCollection service)
        {
            service.AddSingleton<ILoggerManager,  LoggerManager>();
        }
    }
}
