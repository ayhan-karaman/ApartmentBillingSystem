
using System.Collections;
using ApartmentBillingSystem.Domain.Entities;

namespace ApartmentBillingSystem.Application.Services.Interfaces;

public interface IApartmentService
{
    Task<Apartment?> GetByIdAsync(int id);
    Task<IEnumerable<Apartment>> GetByBlockAsync(string block);
    Task AddAsync(Apartment apartment);
    Task UpdateAsync(Apartment apartment);
    Task DeleteAsync(int id);
    Task<IEnumerable> GetAllApartmentsAsync();
}
