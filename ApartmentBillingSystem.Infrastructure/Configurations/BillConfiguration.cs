using ApartmentBillingSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApartmentBillingSystem.Infrastructure.Configurations
{
    public class BillConfiguration : IEntityTypeConfiguration<Bill>
    {
        public void Configure(EntityTypeBuilder<Bill> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(b => b.Type)
                   .IsRequired()
                   .HasConversion<string>();

            builder.Property(b => b.Amount)
                   .HasColumnType("decimal(18,2)")
                   .IsRequired();

            builder.Property(b => b.Month)
                   .IsRequired();
        }
    }
}