
using ApartmentBillingSystem.Application.Helpers;
using ApartmentBillingSystem.Application.Services.Interfaces;
using ApartmentBillingSystem.Domain.Entities;
using ApartmentBillingSystem.Infrastructure.Repositories.Interfaces;

namespace ApartmentBillingSystem.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
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
            
    }
}