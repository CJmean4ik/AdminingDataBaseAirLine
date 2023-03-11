using System.Text.Json;

namespace AdminingDataBaseAirLine.Authentication
{
    public class Loginer
    {
        private readonly AirlineContext _db;
        private const string path = @"C:\Users\Стас\source\repos\AdminingDataBaseAirLine\AdminingDataBaseAirLine\bin\Debug\net6.0-windows10.0.22621.0\Accounts.json";
        private JsonAccountCache jsonCache;
        public Loginer(AirlineContext db)
        {
            _db = db;
            jsonCache = new JsonAccountCache(path);
        }

        public (bool complete, bool isAdmin) CheckingAccount(string name, string password)
        {
            if (!File.Exists(path))
            {
                File.Create(path).Close();

                var account = _db.Accounts
                 .AsNoTracking()
                 .Where(w => w.Name == name)
                 .Select(s => new {password = s.Password, isAdmin = s.IsAdmin })
                 .FirstOrDefault();

                if (account == null) return (false, false);

                jsonCache.CreateAccountInJson(name,account.password,account.isAdmin);
                return (true, account.isAdmin);
            }

            var JsonAccount = jsonCache.GetAccountFromJson(name);

            if (JsonAccount.password != password) return (false, JsonAccount.isAdmin);

            return (true, JsonAccount.isAdmin);
        }
    }
}
