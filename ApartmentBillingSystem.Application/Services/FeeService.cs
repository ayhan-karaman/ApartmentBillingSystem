using ApartmentBillingSystem.Application.Services.Interfaces;
using ApartmentBillingSystem.Domain.Entities;
using ApartmentBillingSystem.Infrastructure.Repositories.Interfaces;

namespace ApartmentBillingSystem.Application.Services
{
    public class FeeService : IFeeService
    {
        private readonly IFeeRepository _feeRepository;

        public FeeService(IFeeRepository feeRepository)
        {
            _feeRepository = feeRepository;
        }

        public async Task<IEnumerable<Fee>> GetAllFeesAsync()
        {
            return await _feeRepository.GetAllAsync();
        }

        public async Task<Fee?> GetByIdAsync(int id)
        {
            return await GetByIdAndExistsAsync(id);
        }
        public async Task<IEnumerable<Fee>> GetByMonthAsync(DateTime month)
        {
            return await _feeRepository.GetFeesByMonthAsync(month);
        }

        public async Task AddAsync(Fee fee)
        {
            await _feeRepository.AddAsync(fee);
            await _feeRepository.SaveChangesAsync();
        }

        public async Task UpdateAsync(Fee fee)
        {
            await Task.Run(() => _feeRepository.Update(fee));
            await _feeRepository.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var fee = await GetByIdAndExistsAsync(id);

            await Task.Run(() => _feeRepository.Delete(fee!));
            await _feeRepository.SaveChangesAsync();
        }
        
        private async Task<Fee?> GetByIdAndExistsAsync(int id)
        {
            Fee? fee = await _feeRepository.GetByIdAsync(id);
            if (fee is not null)
            {
                return fee;
            }
            throw new Exception();
        }

       
    }
}