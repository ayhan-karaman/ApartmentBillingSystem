namespace ApartmentBillingSystem.Domain.Entities;

public class Apartment
{
    public int Id { get; set; }
    public string Block { get; set; } = null!;
    public int Floor { get; set; }
    public string Type { get; set; } = null!; // Örn: "2+1"
    public string Status { get; set; } = null!; // "Dolu" / "Boş"
    public string Number { get; set; } = null!;
    public string OwnershipType { get; set; } = null!; // "Owner" / "Tenant"

    public ICollection<User>? Users { get; set; }
}