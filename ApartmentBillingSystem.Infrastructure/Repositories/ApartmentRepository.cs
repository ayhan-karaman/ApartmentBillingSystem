using ApartmentBillingSystem.Domain.Entities;
using ApartmentBillingSystem.Infrastructure.Contexts;
using ApartmentBillingSystem.Infrastructure.Repositories;
using ApartmentBillingSystem.Infrastructure.Repositories.Interfaces;

public class ApartmentRepository : GenericRepository<Apartment>, IApartmentRepository
{
    public ApartmentRepository(AppDbContext context) : base(context)
    {
    }

    public Task<IEnumerable<Apartment>> GetByBlockAsync(string block)
    {
        throw new NotImplementedException();
    }
}