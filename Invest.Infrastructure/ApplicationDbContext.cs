using Microsoft.EntityFrameworkCore;

namespace Invest.Infrastructure
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

    }
}
