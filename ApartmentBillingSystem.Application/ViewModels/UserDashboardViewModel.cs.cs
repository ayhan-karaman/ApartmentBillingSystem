using ApartmentBillingSystem.Domain.Entities;

namespace ApartmentBillingSystem.Application.ViewModels
{
    public class UserDashboardViewModel
{
    public string FullName { get; set; }
    public string Email { get; set; }
   
    public Apartment Apartment { get; set; }

    public IEnumerable<Bill> Bills { get; set; } 
    public IEnumerable<Fee> Fees { get; set; } 
}

    public class FeeViewModel
    {
    }

    public class BillViewModel
    {
    }
}