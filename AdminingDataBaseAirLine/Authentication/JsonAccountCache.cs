using System.Text.Json;
using System.Text.Json.Nodes;

namespace AdminingDataBaseAirLine.Authentication
{
    internal class JsonAccountCache
    {
        private string path;
        public string Path { get => path; set => path = value; }
        
        private IPasswordHasher hasher;

        public JsonAccountCache(IPasswordHasher hasher)
        {
            this.hasher = hasher;
        }


        public void CreateAccountInJson(string name, string password, bool IsAdmin,int? Id)
        {
            var hash = hasher.CreateHashPassword(password);

            var jsonAccount = new JsonObject
            {
                ["Account"] = new JsonObject
                {                           
                    [name] = new JsonObject()
                    {
                        ["Password"] = hash,
                        ["IsAdmin"] = IsAdmin,
                        ["CashierId"] = Id
                    }
                
                }
            };

            File.AppendAllText(path, jsonAccount.ToJsonString());
        }

        public (string password, bool isAdmin,int? cashierId,string name) GetAccountFromJson(string name,string enteredPassword)
        {
            ReadOnlyMemory<char> JsonAccount = File.ReadAllText(path).AsMemory();

            JsonDocument document = JsonDocument.Parse(JsonAccount);
            JsonElement jsonElement = document.RootElement.GetProperty("Account");

            string password = string.Empty;

            foreach (var item in jsonElement.EnumerateObject())
            {
                if (item.Name == name)
                {
                    password = item.Value.GetProperty("Password").GetString();
                    var isAdmin = item.Value.GetProperty("IsAdmin").GetBoolean();
                    var cashierId = item.Value.GetProperty("CashierId").GetInt32();

                    password = hasher.GetPasswordFromHash(password!, enteredPassword);

                    return (password, isAdmin, cashierId,name)!;
                }
            }
            return (password, false,0,"Empty");
        }
    }
}
