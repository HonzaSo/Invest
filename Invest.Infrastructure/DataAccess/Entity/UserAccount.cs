namespace Invest.Infrastructure.DataAccess.Entity
{
    public class UserAccount
    {
        public Guid Id { get; set; }
        public required Guid UserId { get; set; }
        public Guid? FinancialProductId { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? PurchasePrice { get; set; }
        public FinancialProduct? Product { get; set; }
    }
}
