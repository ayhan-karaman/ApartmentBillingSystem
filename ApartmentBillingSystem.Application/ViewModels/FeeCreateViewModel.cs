namespace ApartmentBillingSystem.Application.ViewModels
{
    public class FeeCreateViewModel
    {
        public int ApartmentId { get; set; }
        public decimal Amount { get; set; }
        public DateTime Month { get; set; }
    }
}
