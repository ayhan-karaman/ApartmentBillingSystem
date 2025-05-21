using ApartmentBillingSystem.Domain.Enums;

namespace ApartmentBillingSystem.Domain.Entities;

public class Apartment
{
    public int Id { get; set; }

    public BlockType Block { get; set; } 
    public int Floor { get; set; }
    public int Number { get; set; }
    public ApartmentType Type { get; set; } 
    public bool IsOccupied { get; set; } = false;

    public int? UserId { get; set; } 
    public ApplicationUser? User { get; set; }

    public ICollection<Bill> Bills { get; set; } = new List<Bill>();
    public ICollection<Fee> Fees { get; set; } = new List<Fee>();
}