using ApartmentBillingSystem.Domain.Enums;

namespace ApartmentBillingSystem.Domain.Entities;

public class Bill
{
    public int Id { get; set; }
        public int ApartmentId { get; set; }
        public Apartment? Apartment { get; set; }

        public BillType BillType { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public bool IsPaid { get; set; }
}
