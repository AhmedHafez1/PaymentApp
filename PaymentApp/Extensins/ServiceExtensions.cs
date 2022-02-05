using Data;
using Microsoft.EntityFrameworkCore;

namespace PaymentApp.Extensins
{
    public static class ServiceExtensions
    {
        public static void ConfigureDbContext(this IServiceCollection services, IConfiguration configuration) =>
            services.AddDbContext<PaymentContext>(optionsBuilder => {
                optionsBuilder.UseSqlServer(configuration.GetConnectionString("DevConnection"));
            });
    }
}
