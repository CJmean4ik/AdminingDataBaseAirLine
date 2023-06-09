using AirlineDataBase.DataBaseContext;
using System.Text.Json;

namespace AdminingDataBaseAirLine.Authentication
{
    public class Loginer
    {
        private readonly AirCompanyContext _db;
        private string _path;
        private JsonAccountCache _jsonCache;
        public Loginer(AirCompanyContext db,string path)
        {
            _db = db;
            _path = path;
            _jsonCache = new JsonAccountCache(_path);
        }

        public (bool complete, bool isAdmin,int cashierId) CheckingAccount(string name, string password,ref string nameMistake)
        {
            if (!File.Exists(_path))
            {
                File.Create(_path).Close();

                var account = _db.Accounts

                 .Where(w => w.Name == name)
                 .Select(s => new {password = s.Password, isAdmin = s.IsAdmin, idCashier = s.Cashier.ID })
                 .FirstOrDefault();

                if (account == null) return (false, false,0);

                _jsonCache.CreateAccountInJson(name,account.password,account.isAdmin, account.idCashier);

                return (true, account.isAdmin,account.idCashier);
            }

            var JsonAccount = _jsonCache.GetAccountFromJson(name);

            if (JsonAccount.password == "none")
            {
                nameMistake = "account";
                return (false, JsonAccount.isAdmin,0);
            }

                      
            if (JsonAccount.password != password)
            {
                nameMistake = "password";
                return (false, JsonAccount.isAdmin, 0);
            }

            return (true, JsonAccount.isAdmin, JsonAccount.cashierId);
        }
    }
}
