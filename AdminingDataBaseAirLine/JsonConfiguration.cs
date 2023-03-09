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

        public async Task<string> GetConnectionString(string path)
        {
            using (JsonDocument jsonDocument = await JsonDocument.ParseAsync(File.Open(path, FileMode.Open)))
            {
               return jsonDocument.RootElement.GetProperty("MsSqlConnection").GetString()!;           
            }

        }
    }
}
