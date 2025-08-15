using Invest.Infrastructure.DataAccess.Entity;
using Microsoft.EntityFrameworkCore;

namespace Invest.Infrastructure.DataAccess
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<UserAccount> UserAccounts { get; set; }
        public DbSet<FinancialProduct> FinancialProducts { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().Property(u => u.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<FinancialProduct>().Property(fp => fp.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<UserAccount>().Property(ua => ua.Id).ValueGeneratedOnAdd();
        }


    }
}
