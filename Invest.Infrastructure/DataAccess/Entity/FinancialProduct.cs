using System.ComponentModel.DataAnnotations;

namespace Invest.Infrastructure.DataAccess.Entity
{
    public class FinancialProduct: EntityBase
    {
        public required string Symbol { get; set; }
        public required string From { get; set; }

        public double Open { get; set; }

        public double High { get; set; }

        public double Low { get; set; }

        public double Close { get; set; }

        public long Volume { get; set; }
    }
}
