
using ApartmentBillingSystem.Application.ViewModels;
using ApartmentBillingSystem.Domain.Entities;

namespace ApartmentBillingSystem.Application.Services.Interfaces
{
    public interface IUserService
    {
        Task<ApplicationUser?> GetUserByIdAsync(int id);
        Task<ApplicationUser?> GetUserByEmailAsync(string email);
        Task AddUserAsync(ApplicationUser user);
        Task UpdateUserAsync(ApplicationUser user);
        Task DeleteUserAsync(int id);
        Task<IEnumerable<ApplicationUser>?> GetAllUsersAsync();
        Task<UserDashboardViewModel> GetUserDashboardViewInfoAsync(int userId);
    }
}