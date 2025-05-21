namespace ApartmentBillingSystem.Domain.Entities;

public class Message
{
     public int Id { get; set; }

    // Mesajı gönderen kullanıcı
    public int SenderId { get; set; }
    public ApplicationUser Sender { get; set; } = null!;

    // Mesajı alan kullanıcı (örn. admin veya başka kullanıcı)
    public int ReceiverId { get; set; }
    public ApplicationUser Receiver { get; set; } = null!;

    public string Subject { get; set; } = string.Empty;

    public string Content { get; set; } = string.Empty;

    public DateTime SentAt { get; set; } = DateTime.UtcNow;

    public bool IsRead { get; set; } = false;
}