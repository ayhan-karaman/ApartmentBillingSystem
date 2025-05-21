using Microsoft.AspNetCore.Identity;

namespace ApartmentBillingSystem.Domain.Entities;

public class ApplicationUser : IdentityUser<int>
{
    public string FullName { get; set; }
    public string TCNo { get; set; } 
    public string VehiclePlate { get; set; }


    public int ApartmentId { get; set; }
    public Apartment? Apartment { get; set; }

    public ICollection<Message> SentMessages { get; set; } = new List<Message>();
    public ICollection<Message> ReceivedMessages { get; set; } = new List<Message>();
}
