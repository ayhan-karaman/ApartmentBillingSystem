namespace ApartmentBillingSystem.Domain.Entities;

public class Fee
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public User? User { get; set; }

    public decimal Amount { get; set; }
    public DateTime DueDate { get; set; }
    public bool IsPaid { get; set; }
}
