

using ApartmentBillingSystem.Domain.Entities;
using ApartmentBillingSystem.Infrastructure.Contexts;
using ApartmentBillingSystem.Infrastructure.Repositories.Interfaces;

namespace ApartmentBillingSystem.Infrastructure.Repositories
{
    public class BillRepository : GenericRepository<Bill>, IBillRepository
    {
        public BillRepository(AppDbContext context) : base(context)
        {
        }
    }

}