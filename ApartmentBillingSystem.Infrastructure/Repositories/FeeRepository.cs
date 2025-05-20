

using ApartmentBillingSystem.Domain.Entities;
using ApartmentBillingSystem.Infrastructure.Contexts;
using ApartmentBillingSystem.Infrastructure.Repositories.Interfaces;

namespace ApartmentBillingSystem.Infrastructure.Repositories
{
    public class FeeRepository : GenericRepository<Fee>, IFeeRepository
    {
        public FeeRepository(AppDbContext context) : base(context)
        {
        }
    }

}