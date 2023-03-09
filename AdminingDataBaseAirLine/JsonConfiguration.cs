using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AdminingDataBaseAirLine
{
    public class JsonConfiguration
    {

        public static async Task<string> GetConnectionString(string path)
        {
            using (JsonDocument jsonDocument = await JsonDocument.ParseAsync(File.OpenRead(path)))
            {
               return jsonDocument.RootElement.GetProperty("Connections").GetProperty("MsSqlConnection").GetString()!;           
            }

        }
    }
}
