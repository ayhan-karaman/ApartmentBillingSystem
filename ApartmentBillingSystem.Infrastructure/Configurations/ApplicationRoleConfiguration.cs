
using ApartmentBillingSystem.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApartmentBillingSystem.Infrastructure.Configurations;

public class ApplicationRoleConfiguration : IEntityTypeConfiguration<ApplicationRole>
{
    public void Configure(EntityTypeBuilder<ApplicationRole> builder)
    {
        builder.HasData(
            new ApplicationRole() {Id = 1, Name = "User", NormalizedName = "USER" },
            new ApplicationRole() {Id = 2, Name = "Editor", NormalizedName = "EDITOR" },
            new ApplicationRole() {Id = 3, Name = "Admin", NormalizedName = "ADMIN" }
        );
    }
}
