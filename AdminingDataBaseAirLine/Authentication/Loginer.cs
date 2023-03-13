using System.Text.Json;

namespace AdminingDataBaseAirLine.Authentication
{
    public class Loginer
    {
        private readonly AirlineContext _db;
        private string _path;
        private JsonAccountCache _jsonCache;
        public Loginer(AirlineContext db,string path)
        {
            _db = db;
            _path = path;
            _jsonCache = new JsonAccountCache(_path);
        }

        public (bool complete, bool isAdmin) CheckingAccount(string name, string password,ref string nameMistake)
        {
            if (!File.Exists(_path))
            {
                File.Create(_path).Close();

                var account = _db.Accounts
                 .AsNoTracking()
                 .Where(w => w.Name == name)
                 .Select(s => new {password = s.Password, isAdmin = s.IsAdmin })
                 .FirstOrDefault();

                if (account == null) return (false, false);

                _jsonCache.CreateAccountInJson(name,account.password,account.isAdmin);
                return (true, account.isAdmin);
            }

            var JsonAccount = _jsonCache.GetAccountFromJson(name);

            if (JsonAccount.password == "none")
            {
                nameMistake = "account";
                return (false, JsonAccount.isAdmin);
            }

                      
            if (JsonAccount.password != password)
            {
                nameMistake = "password";
                return (false, JsonAccount.isAdmin);
            }

            return (true, JsonAccount.isAdmin);
        }
    }
}
