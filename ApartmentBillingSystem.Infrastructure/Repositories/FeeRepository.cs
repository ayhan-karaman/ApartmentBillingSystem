

using ApartmentBillingSystem.Domain.Entities;
using ApartmentBillingSystem.Infrastructure.Contexts;
using ApartmentBillingSystem.Infrastructure.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApartmentBillingSystem.Infrastructure.Repositories
{
    public class FeeRepository : GenericRepository<Fee>, IFeeRepository
    {
        public FeeRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<List<Fee>> GetFeesByMonthAsync(DateTime month)
        {
            return await _context.Fees
                .Include(f => f.Apartment)
                .Where(f => f.Month.Month == month.Month && f.Month.Year == month.Year)
                .ToListAsync();
        }
    }

}