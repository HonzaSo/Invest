using System.ComponentModel.DataAnnotations;

namespace Invest.Infrastructure.DataAccess.Entity
{
    public abstract class EntityBase
    {
        [Key]
        public int Id { get; set; }
    }
}
