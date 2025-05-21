using ApartmentBillingSystem.Domain.Entities;

namespace ApartmentBillingSystem.Infrastructure.Repositories.Interfaces
{
    public interface IFeeRepository : IGenericRepository<Fee>
    {
             Task<List<Fee>> GetFeesByMonthAsync(DateTime month);
    }
    

}