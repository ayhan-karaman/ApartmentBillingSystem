using System.Collections;
using ApartmentBillingSystem.Application.Services.Interfaces;
using ApartmentBillingSystem.Domain.Entities;
using ApartmentBillingSystem.Infrastructure.Repositories.Interfaces;
namespace ApartmentBillingSystem.Application.Services;

public class ApartmentService : IApartmentService
{
    private readonly IApartmentRepository _apartmentRepository;

    public ApartmentService(IApartmentRepository apartmentRepository)
    {
        _apartmentRepository = apartmentRepository;
    }


    public async Task<Apartment?> GetByIdAsync(int id)
    {
        return await _apartmentRepository.GetByIdAsync(id);
    }

    public async Task<Apartment?> GetByNumberAsync(string number)
    {
        return await _apartmentRepository.GetSingleAsync(x => x.Type == number);
    }

    public async Task<IEnumerable<Apartment>> GetByBlockAsync(string block)
    {
        return await _apartmentRepository.GetByBlockAsync(block);
    }

    public async Task AddAsync(Apartment apartment)
    {
        await _apartmentRepository.AddAsync(apartment);
        await _apartmentRepository.SaveChangesAsync();
    }

    public async Task UpdateAsync(Apartment apartment)
    {
        _apartmentRepository.Update(apartment);
        await _apartmentRepository.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var apartment = await _apartmentRepository.GetByIdAsync(id);
        if (apartment is not null)
        {
            _apartmentRepository.Delete(apartment);
            await _apartmentRepository.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable> GetAllApartmentsAsync()
    {
        return await _apartmentRepository.GetAllAsync();
    }
}