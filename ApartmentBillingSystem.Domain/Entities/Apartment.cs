namespace ApartmentBillingSystem.Domain.Entities;

public class Apartment
{
    public int Id { get; set; }
    public string Block { get; set; } = null!;
    public int Floor { get; set; }
    public int Number { get; set; }
    public string Type { get; set; } = null!;  // Ör: 2+1, 3+1
    public bool IsOccupied { get; set; } = false;

    // Navigation
    public ICollection<User> Users { get; set; } = new List<User>();
    public ICollection<Bill> Bills { get; set; } = new List<Bill>();
}