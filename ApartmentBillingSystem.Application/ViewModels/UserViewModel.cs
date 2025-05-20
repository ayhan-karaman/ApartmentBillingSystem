namespace ApartmentBillingSystem.Application.ViewModels
{
    public class UserViewModel
    {
        public string FullName { get; set; } = null!;
        public string IdentityNumber { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string? CarPlate { get; set; }

        // Şifre alanı olmayabilir çünkü servis içinde otomatik oluşturulacak
        // public string Password { get; set; } 
    }
}
