namespace Invest.Infrastructure.Configuration
{
    public class Database
    {
        public required string Server { get; set; }
        public int Port { get; set; }
        public required string User { get; set; }
        public required string Password { get; set; }
        public required string DatabaseName { get; set; }

        public string GetConnectionString
        {
            get
            {
                return $"Host={Server};Port={Port};Database={DatabaseName};Username={User};Password={Password};";
            }
        }
    }
}
