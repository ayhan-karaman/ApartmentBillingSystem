namespace ApartmentBillingSystem.Application.ViewModels
{
    public class UserDashboardViewModel
{
    public string FullName { get; set; }
    public string Email { get; set; }

    public string ApartmentBlock { get; set; }
    public int ApartmentNumber { get; set; }

    public List<BillViewModel> Bills { get; set; } = new();
    public List<FeeViewModel> Fees { get; set; } = new();
}

    public class FeeViewModel
    {
    }

    public class BillViewModel
    {
    }
}