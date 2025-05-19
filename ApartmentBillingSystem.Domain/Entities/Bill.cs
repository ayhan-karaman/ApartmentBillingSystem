namespace ApartmentBillingSystem.Domain.Entities;

public class Bill
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public User? User { get; set; }

    public string Type { get; set; } = null!; // Elektrik, Su, Doğalgaz
    public decimal Amount { get; set; }
    public DateTime DueDate { get; set; }
    public bool IsPaid { get; set; }
}
