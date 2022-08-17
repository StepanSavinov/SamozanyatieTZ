using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
namespace DependencyConfig
{
    public static class Config
    {
        public static IServiceProvider RegisterServices(IServiceCollection services)
        {
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            return services.BuildServiceProvider();
        }
    }
}