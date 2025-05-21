using ApartmentBillingSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApartmentBillingSystem.Infrastructure.Configurations;

public class FeeConfiguration : IEntityTypeConfiguration<Fee>
{
       public void Configure(EntityTypeBuilder<Fee> builder)
       {
              builder.HasKey(f => f.Id);

              builder.Property(f => f.Amount)
                     .HasColumnType("decimal(18,2)")
                     .IsRequired();

              builder.Property(f => f.Month)
                     .IsRequired();
       }
}
