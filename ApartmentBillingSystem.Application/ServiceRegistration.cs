using ApartmentBillingSystem.Application.Services;
using ApartmentBillingSystem.Application.Services.Interfaces;
using ApartmentBillingSystem.Infrastructure.Repositories;
using ApartmentBillingSystem.Infrastructure.Repositories.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace ApartmentBillingSystem.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            // Servis'leri kaydet
            services.AddScoped<IApartmentService, ApartmentService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IBillService, BillService>();
            services.AddScoped<IFeeService, FeeService>();
            services.AddScoped<IMessageService, MessageService>();


        }
    }
}