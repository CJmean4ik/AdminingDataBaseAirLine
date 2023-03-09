using DataBaseModel.Entities.Accounts;
using System.Data.Entity;

namespace AdminingDataBaseAirLine.Authentication
{
    public class AccountContext : DbContext
    {
        public DbSet<Cashier> Cashiers { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public AccountContext(string connectionString) : base(connectionString)
        {

        }
    }
}
