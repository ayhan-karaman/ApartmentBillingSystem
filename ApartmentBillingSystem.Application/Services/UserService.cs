
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

        public Task<User?> GetUserByIdAsync(int id) => _userRepository.GetByIdAsync(id);

        public async Task<User?> GetUserByEmailAsync(string email) => await _userRepository.GetSingleAsync(x => x.Email == email);

        public async Task AddUserAsync(User user) => await _userRepository.AddAsync(user);

        public async Task UpdateUserAsync(User user) => await Task.Run(() => _userRepository.Update(user));

        public async Task DeleteUserAsync(int id)
        {
            User? user = await _userRepository.GetByIdAsync(id);
            if (user is not null)
                await Task.Run(() => _userRepository.Delete(user));

        }

        public async Task<IEnumerable<User>?> GetAllUsersAsync()
        => await _userRepository.GetAllAsync();
            
    }
}