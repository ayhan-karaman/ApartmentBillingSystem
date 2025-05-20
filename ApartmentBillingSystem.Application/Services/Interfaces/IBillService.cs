
using ApartmentBillingSystem.Domain.Entities;

namespace ApartmentBillingSystem.Application.Services.Interfaces
{
    public interface IBillService
    {
        Task AddAsync(Bill bill);
    }
}