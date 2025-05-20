namespace ApartmentBillingSystem.Domain.Entities;

public class User
{
    public int Id { get; set; }
        public string FullName { get; set; } = null!;
        public string TCNo { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string VehiclePlate { get; set; } = null!;
        //public UserRole Role { get; set; }

        public int ApartmentId { get; set; }
        public Apartment? Apartment { get; set; }
}
