using ApartmentBillingSystem.Domain.Enums;

namespace ApartmentBillingSystem.Domain.Entities;

public class Fee
{
    public int Id { get; set; }

    public int ApartmentId { get; set; }
    public Apartment Apartment { get; set; }

    public DateTime Month { get; set; }
    public decimal Amount { get; set; }

    public bool IsPaid { get; set; } = false;
}
