using ApartmentBillingSystem.Domain.Entities;

namespace ApartmentBillingSystem.Application.Services.Interfaces
{
    public interface IFeeService
    {
        Task<IEnumerable<Fee>> GetAllFeesAsync();
        Task<Fee?> GetByIdAsync(int id);
        Task<IEnumerable<Fee>> GetByMonthAsync(DateTime month);
        Task AddAsync(Fee fee);
        Task UpdateAsync(Fee fee);
        Task DeleteAsync(int id);
    }
}