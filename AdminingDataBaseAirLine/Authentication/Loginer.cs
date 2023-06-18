using AdminingDataBaseAirLine.Authentication.Hash;
using AirlineDataBase;

namespace AdminingDataBaseAirLine.Authentication
{
    public class Loginer
    {
        private readonly AirCompanyContext _db;
        private string _path;
        private JsonAccountCache _jsonCache;
        private MainForm _mainForm;

        public string Path { get => _path; set => _path = value; }

        public Loginer(AirCompanyContext db, MainForm mainForm)
        {
            _db = db;
            _mainForm = mainForm;
            _jsonCache = new JsonAccountCache(new PasswordHasher());
        }

        public (bool complete, bool isAdmin, int? cashierId) CheckingAccount(string name, string password, ref string nameMistake)
        {
           
            _path = _path.Replace("PATH_NAME", name +".json");

            _jsonCache.Path = _path;

            var createdFile = HandlingNotExistFile(name, password,ref nameMistake);
            if (createdFile.complete) return createdFile;

            if (nameMistake == "account")
                return (false, false, 0);

            var fillFile = HandlingEmptyFile(name, password, ref nameMistake);
            if (fillFile.complete) return fillFile;

            var isAded = AddingAccountIfNotExist(name, password, ref nameMistake);
            if (isAded.complete) return isAded;

            if (nameMistake == "account")
                return (false, false, 0);
            
            

            var JsonAccount = _jsonCache.GetAccountFromJson(name, password);

            if (JsonAccount.password == "none")
            {
                nameMistake = "password";
                return (false, JsonAccount.isAdmin, 0);
            }

            if (JsonAccount.name == "Empty")
            {              
                nameMistake = "account";
                return (false, JsonAccount.isAdmin, 0);
            }

            return (true, JsonAccount.isAdmin, JsonAccount.cashierId);
        }

        private (bool complete, bool isAdmin, int? cashierId) HandlingEmptyFile(string name, string password, ref string nameMistake)
        {
            if (!IsEmptyFile()) return (false, false, 0);
            var account = SelectAccount(name,password);

            if (account.password == "Not Found")
            {
                nameMistake = "account";
                return (false, false, 0);
            }

            if (account.password == "")
                return (false, account.IsAdmin, 0);

            _jsonCache.CreateAccountInJson(name, account.password, account.IsAdmin, account.idCashier);
            return (true, account.IsAdmin, account.idCashier);

        }
        private (bool complete, bool isAdmin, int? cashierId) AddingAccountIfNotExist(string name, string password, ref string nameMistake)
        {
           var json = File.ReadAllText(_path);
            if (json.Contains($"{name}")) return (false,false, 0);

            var account = SelectAccount(name,password);

            if (account.password == "Not Found")
            {
                nameMistake = "account";
                return (false, false, 0);
            }

            if (account.password == "")
                return (false, account.IsAdmin, 0);

            _jsonCache.CreateAccountInJson(name, account.password, account.IsAdmin, account.idCashier);
            return (true, account.IsAdmin, account.idCashier);
        }
        private (bool complete, bool isAdmin, int? cashierId) HandlingNotExistFile(string name, string password, ref string nameMistake)
        {
            if (!File.Exists(_path))
            {
                var account = SelectAccount(name, password);

                if (account.password == "Not Found")
                {
                    nameMistake = "account";
                    return (false, false, 0);
                }

                File.Create(_path).Close();
           
                _jsonCache.CreateAccountInJson(name, account.password, account.IsAdmin, account.idCashier);

                return (true, account.IsAdmin, account.idCashier);
            }
            return (false, false, 0);
        }
        private (string password, bool IsAdmin, int? idCashier) SelectAccount(string name,string password)
        {          
            var account = _db.Accounts
            .Where(w => w.Name == name && w.Password == password)
            .Select(s => new { password = s.Password, isAdmin = s.IsAdmin, idCashier = s.Cashier.ID ?? 0 })
            .FirstOrDefault();

            if (account == null) return ("Not Found", false, 0);
            
            return (account.password, account.isAdmin, account.idCashier);
        }
        private bool IsEmptyFile()
        {
            FileInfo fileInfo = new FileInfo(_path);

            if (fileInfo.Length == 0) return true;

            return false;

        }
    }
}
