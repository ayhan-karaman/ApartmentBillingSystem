using ApartmentBillingSystem.Domain.Enums;

namespace ApartmentBillingSystem.Application.ViewModels
{
    public class BillCreateViewModel
    {
        public int ApartmentId { get; set; }
        public BillType BillType { get; set; } = BillType.Electricity;
        public decimal Amount { get; set; }
        public DateTime Month { get; set; }
    }
}
