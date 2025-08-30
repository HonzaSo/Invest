using System.ComponentModel.DataAnnotations;

namespace Invest.Infrastructure.DataAccess.Entity
{
    public class FinancialProduct: EntityBase
    {
        [Required(ErrorMessage = "Symbol produktu je vyzadovan.")]
        public required string Symbol { get; set; }
        [Required(ErrorMessage = "Datum je povinny.")]
        //[RegularExpression("((?:19|20)\\d\\d)-(0?[1-9]|1[012])-([12][0-9]|3[01]|0?[1-9])")]
        public required string From { get; set; }

        public double Open { get; set; }

        public double High { get; set; }

        public double Low { get; set; }

        public double Close { get; set; }

        public long Volume { get; set; }
    }
}
