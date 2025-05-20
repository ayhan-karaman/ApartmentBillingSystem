
using Microsoft.EntityFrameworkCore;
using ApartmentBillingSystem.Domain.Entities;

namespace ApartmentBillingSystem.Infrastructure.Contexts;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Apartment> Apartments { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Bill> Bills { get; set; }
    public DbSet<Fee> Fees { get; set; }
    public DbSet<Message> Messages { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<User>()
                .HasOne(u => u.Apartment)
                .WithMany(a => a.Users)
                .HasForeignKey(u => u.ApartmentId);

            modelBuilder.Entity<Bill>()
                .HasOne(b => b.Apartment)
                .WithMany(a => a.Bills)
                .HasForeignKey(b => b.ApartmentId);

            modelBuilder.Entity<Message>()
                .HasOne(m => m.FromUser)
                .WithMany()
                .HasForeignKey(m => m.FromUserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Message>()
                .HasOne(m => m.ToUser)
                .WithMany()
                .HasForeignKey(m => m.ToUserId)
                .OnDelete(DeleteBehavior.Restrict);
    }
}
