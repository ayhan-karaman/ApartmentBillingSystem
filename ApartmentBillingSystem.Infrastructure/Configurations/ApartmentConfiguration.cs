using ApartmentBillingSystem.Domain.Entities;
using ApartmentBillingSystem.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace ApartmentBillingSystem.Infrastructure.Configurations;

public class ApartmentConfiguration : IEntityTypeConfiguration<Apartment>
{
    public void Configure(EntityTypeBuilder<Apartment> builder)
    {
        builder.HasKey(a => a.Id);

        builder.Property(a => a.Block)
               .IsRequired()
               .HasConversion<string>(); // Enum'u string olarak saklamak için

        builder.Property(a => a.Type)
               .IsRequired()
               .HasConversion<string>();

        builder.Property(a => a.Floor).IsRequired();
        builder.Property(a => a.Number).IsRequired();

        builder.HasMany(a => a.Bills)
               .WithOne(b => b.Apartment)
               .HasForeignKey(b => b.ApartmentId);

        builder.HasMany(a => a.Fees)
               .WithOne(f => f.Apartment)
               .HasForeignKey(f => f.ApartmentId);

        builder.HasOne(a => a.User)
                .WithMany()
                .HasForeignKey(a => a.UserId)
                .OnDelete(DeleteBehavior.Restrict);

        builder.HasData(
            new Apartment
            {
                Id = 1,
                Type = ApartmentType.TwoPlusOne,
                IsOccupied = false,
                Floor = 3,
                Number = 302,
                Block = BlockType.A,
            }
        );
    }
}
