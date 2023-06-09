using System.Text.Json;
using System.Text.Json.Nodes;

namespace AdminingDataBaseAirLine.Authentication
{
    internal class JsonAccountCache
    {
        private string path;

        public JsonAccountCache(string path)
        {
            this.path = path;
        }

        public void CreateAccountInJson(string name, string password, bool IsAdmin,int Id)
        {
            var jsonAccount = new JsonObject
            {
                ["Accounts"] = new JsonObject()
                {
                    [name] = new JsonObject()
                    {
                        ["Password"] = password,
                        ["IsAdmin"] = IsAdmin,
                        ["CashierId"] = Id
                    }
                }
            };
            File.AppendAllText(path, jsonAccount.ToJsonString());
        }

        public (string password, bool isAdmin,int cashierId) GetAccountFromJson(string name)
        {
            ReadOnlyMemory<char> JsonAccount = File.ReadAllText(path).AsMemory();
            JsonDocument document = JsonDocument.Parse(JsonAccount);
            JsonElement jsonElement = document.RootElement.GetProperty("Accounts");
            foreach (var item in jsonElement.EnumerateObject())
            {
                if (item.Name == name)
                {
                    var password = item.Value.GetProperty("Password").GetString();
                    var isAdmin = item.Value.GetProperty("IsAdmin").GetBoolean();
                    var cashierId = item.Value.GetProperty("CashierId").GetInt32();
                    return (password, isAdmin, cashierId)!;
                }
            }
            return ("none", false,0);
        }
    }
}
