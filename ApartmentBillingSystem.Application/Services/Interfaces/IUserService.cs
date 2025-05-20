
using ApartmentBillingSystem.Domain.Entities;

namespace ApartmentBillingSystem.Application.Services.Interfaces
{
    public interface IUserService
    {
        Task<User?> GetUserByIdAsync(int id);
        Task<User?> GetUserByEmailAsync(string email);
        Task AddUserAsync(User user);
        Task UpdateUserAsync(User user);
        Task DeleteUserAsync(int id);
        Task<IEnumerable<User>?> GetAllUsersAsync();
    }
}