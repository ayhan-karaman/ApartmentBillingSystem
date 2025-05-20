using ApartmentBillingSystem.Infrastructure.Contexts;
using ApartmentBillingSystem.Infrastructure.Repositories;
using ApartmentBillingSystem.Infrastructure.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ApartmentBillingSystem.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("SqlServerConnection"));
            });

            // Repository'leri kaydet
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IApartmentRepository, ApartmentRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IBillRepository, BillRepository>();
            services.AddScoped<IFeeRepository, FeeRepository>();
            services.AddScoped<IMessageRepository, MessageRepository>();

        }
    }
}