using System.ComponentModel.DataAnnotations;

namespace ApartmentBillingSystem.Application.ViewModels.User
{
    public class CreateUserViewModel
    {
        [Required]
        public string FullName { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string PhoneNumber { get; set; } = string.Empty;

        public string? TcNo { get; set; }

        public string? CarPlate { get; set; }
    }
}
