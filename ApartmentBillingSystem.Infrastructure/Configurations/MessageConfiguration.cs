namespace ApartmentBillingSystem.Infrastructure.Configurations;

using ApartmentBillingSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class MessageConfiguration : IEntityTypeConfiguration<Message>
{
    public void Configure(EntityTypeBuilder<Message> builder)
    {
        builder.HasKey(m => m.Id);


        builder.HasOne(m => m.Sender)
            .WithMany(u => u.SentMessages)
            .HasForeignKey(m => m.SenderId)
            .OnDelete(DeleteBehavior.Restrict);


        builder.HasOne(m => m.Receiver)
            .WithMany(u => u.ReceivedMessages)  
            .HasForeignKey(m => m.ReceiverId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Property(m => m.Subject)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(m => m.Content)
            .IsRequired();

        builder.Property(m => m.SentAt)
            .HasDefaultValueSql("GETUTCDATE()");

        builder.Property(m => m.IsRead)
            .HasDefaultValue(false);
    }
}
