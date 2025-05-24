
using ApartmentBillingSystem.Application.Helpers;
using ApartmentBillingSystem.Application.Services.Interfaces;
using ApartmentBillingSystem.Application.ViewModels;
using ApartmentBillingSystem.Domain.Entities;
using ApartmentBillingSystem.Infrastructure.Repositories.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace ApartmentBillingSystem.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IBillRepository _billRepository;
        private readonly IFeeRepository _feeRepository;
        private readonly UserManager<ApplicationUser> _userManager;

        public UserService(IUserRepository userRepository, UserManager<ApplicationUser> userManager, IBillRepository billRepository, IFeeRepository feeRepository)
        {
            _userRepository = userRepository;
            _userManager = userManager;
            _billRepository = billRepository;
            _feeRepository = feeRepository;
        }

        public Task<ApplicationUser?> GetUserByIdAsync(int id) => _userRepository.GetByIdAsync(id);

        public async Task<ApplicationUser?> GetUserByEmailAsync(string email) => await _userRepository.GetSingleAsync(x => x.Email == email);

        public async Task AddUserAsync(ApplicationUser user) => await _userRepository.AddAsync(user);

        public async Task UpdateUserAsync(ApplicationUser user)
        {
            await Task.Run(() => _userRepository.Update(user));
            await _userRepository.SaveChangesAsync();
        }

        public async Task DeleteUserAsync(int id)
        {
            ApplicationUser? user = await _userRepository.GetByIdAsync(id);
            if (user is not null)
            {
                await Task.Run(() => _userRepository.Delete(user));
                await _userRepository.SaveChangesAsync();
            }


        }

        public async Task<IEnumerable<ApplicationUser>?> GetAllUsersAsync()
        => await _userRepository.GetAllAsync();

        public async Task<UserDashboardViewModel> GetUserDashboardViewInfoAsync(int userId)
        {
            var user = await _userManager.Users
            .Include(u => u.Apartment)
            .FirstOrDefaultAsync(u => u.Id == userId);

            var apartmentId = user.ApartmentId;
            IEnumerable<Bill> bills = await _billRepository.GetAllAsync(b => b.ApartmentId == apartmentId);
            bills = bills.OrderByDescending(b => b.Month);

            var fees = await _feeRepository.GetAllAsync(f => f.ApartmentId == apartmentId);
            fees = fees.OrderByDescending(f => f.Month);

            var viewModel = new UserDashboardViewModel
            {
                Apartment = user.Apartment,
                Bills = bills,
                Fees = fees
            };

            return viewModel;

        }
    }
}