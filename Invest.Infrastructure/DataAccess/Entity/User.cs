namespace Invest.Infrastructure.DataAccess.Entity
{
    public class User
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public required string FullName { get; set; }

        public ICollection<UserAccount>? UserAccounts { get; set; }
    }
}
