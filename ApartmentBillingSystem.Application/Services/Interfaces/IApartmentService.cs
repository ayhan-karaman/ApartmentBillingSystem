
using ApartmentBillingSystem.Domain.Entities;

namespace ApartmentBillingSystem.Application.Services.Interfaces;

public interface IApartmentService
{
    Task<IEnumerable<Apartment>> GetAllAsync();
    Task<Apartment?> GetByIdAsync(int id);
    Task<IEnumerable<Apartment>> GetByBlockAsync(string block);
    Task<Apartment?> GetByNumberAsync(string number);
    Task AddAsync(Apartment apartment);
    Task UpdateAsync(Apartment apartment);
    Task DeleteAsync(int id);
}
