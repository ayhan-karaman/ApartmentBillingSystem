

using ApartmentBillingSystem.Domain.Entities;
using ApartmentBillingSystem.Infrastructure.Contexts;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace ApartmentBillingSystem.Web.Infrastructure.Extensions
{
    public static class ApplicationExtensions
    {
        public static void ConfigureAndCheckMigration(this IApplicationBuilder app)
        {
            AppDbContext context = app
            .ApplicationServices
            .CreateScope()
            .ServiceProvider
            .GetRequiredService<AppDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();

            }
           
        }
        public static async void ConfigureDefaultAdminUserAsync(this IApplicationBuilder app)
        {
            const string adminUser = "admin@site.com";
            const string password = "Admin+123456";

            // UserManager
            UserManager<ApplicationUser> userManager =
            app.ApplicationServices
            .CreateScope()
            .ServiceProvider
            .GetRequiredService<UserManager<ApplicationUser>>();

            // RoleManager
            RoleManager<ApplicationRole> roleManager = app
            .ApplicationServices
            .CreateScope()
            .ServiceProvider
            .GetRequiredService<RoleManager<ApplicationRole>>();
            ApplicationUser? user = await userManager.FindByNameAsync(adminUser);
            if (user is null)
            {
                user = new ApplicationUser()
                {
                    Email = adminUser,
                    PhoneNumber = "5351112233",
                    UserName = adminUser,
                    EmailConfirmed = true,
                    NormalizedEmail = adminUser.ToUpper(),
                    FullName = "Admin User",
                    TCNo = "12345678901",
                    VehiclePlate = "34 GRS 28",
                    ApartmentId = 1,
                    SecurityStamp = Guid.NewGuid().ToString(), // Çok önemli!
                };
               
                var result = await userManager.CreateAsync(user, password);
                if (!result.Succeeded)
                {
                    throw new Exception("Admin user could not created.");
                }
                
                var roleResult = await userManager.AddToRolesAsync(user, roleManager.Roles.Select(x => x.Name).ToList());

                if (!roleResult.Succeeded)
                    throw new Exception("System have problems with role defination for Admin.");
            }
        }
    }
}