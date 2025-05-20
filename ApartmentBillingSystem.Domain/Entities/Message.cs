namespace ApartmentBillingSystem.Domain.Entities;

public class Message
{
    public int Id { get; set; }
    public int FromUserId { get; set; }
    public User? FromUser { get; set; }

    public int ToUserId { get; set; }
    public User? ToUser { get; set; }

    public string Content { get; set; } = null!;
    public DateTime SentAt { get; set; }
    public bool IsRead { get; set; }
}