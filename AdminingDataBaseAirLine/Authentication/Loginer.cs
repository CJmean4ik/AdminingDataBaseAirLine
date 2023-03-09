using System.Data.Entity;

namespace AdminingDataBaseAirLine.Authentication
{
    public class Loginer
    {
        private readonly AirlineContext _db;

        public Loginer(AirlineContext db) => _db = db;


        public (bool complete,bool isAdmin) CheckingAccount(string name, string password)
        {
            var account = _db.Accounts
                  .AsNoTracking()
                  .AsEnumerable()
                  .Where(w => w.Name == name)
                  .Select(s => new {password = s.Password, isAdmin = s.IsAdmin })
                  .FirstOrDefault();

            if (account.password != password)           
                return (false,account.isAdmin);

            return (true, account.isAdmin);                                            
        }
    }
}
