
using ApartmentBillingSystem.Domain.Entities;

namespace ApartmentBillingSystem.Infrastructure.Repositories.Interfaces;

public interface IApartmentRepository : IGenericRepository<Apartment>
{
    // Apartment entity'ye özel işlemler buraya yazılır
    Task<IEnumerable<Apartment>> GetByBlockAsync(string block);
}