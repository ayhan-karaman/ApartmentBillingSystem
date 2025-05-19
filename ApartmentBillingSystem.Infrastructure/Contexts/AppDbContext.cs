
using Microsoft.EntityFrameworkCore;
using ApartmentBillingSystem.Domain.Entities;

namespace ApartmentBillingSystem.Infrastructure.Contexts;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Apartment> Apartments { get; set;}
    public DbSet<User> Users { get; set;}
    public DbSet<Bill> Bills { get; set;}
    public DbSet<Fee> Fees { get; set;}
    public DbSet<Message> Messages { get; set;}
}
