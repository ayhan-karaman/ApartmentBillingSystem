namespace ApartmentBillingSystem.Domain.Entities;

public class User
{
    public int Id { get; set; }
    public string FullName { get; set; } = null!;
    public string IdentityNumber { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Phone { get; set; } = null!;
    public string? CarPlate { get; set; }
    public string Password { get; set; } = null!;
    public bool IsAdmin { get; set; }

    public int ApartmentId { get; set; }
    public Apartment? Apartment { get; set; }

    public ICollection<Bill>? Bills { get; set; }
    public ICollection<Fee>? Fees { get; set; }
}
