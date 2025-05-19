namespace ApartmentBillingSystem.Domain.Entities;

public class Message
{
    public int Id { get; set; }
    public int SenderId { get; set; }
    public string Content { get; set; } = null!;
    public DateTime SentAt { get; set; }

    public User? Sender { get; set; }
}