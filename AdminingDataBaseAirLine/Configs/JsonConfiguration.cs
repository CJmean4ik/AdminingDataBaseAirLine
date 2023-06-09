﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AdminingDataBaseAirLine.Configs
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
        public static async Task<string> GetPathToJsonAccount(string path)
        {
            using (JsonDocument jsonDocument = await JsonDocument.ParseAsync(File.OpenRead(path)))
            {
                return jsonDocument.RootElement.GetProperty("Paths").GetProperty("JsonAccount").GetString()!;
            }

        }
        public static async Task<string> GetPathToTemplateWord(string path)
        {
            using (JsonDocument jsonDocument = await JsonDocument.ParseAsync(File.OpenRead(path)))
            {
                return jsonDocument.RootElement.GetProperty("Paths").GetProperty("TemplateWord").GetString()!;
            }

        }
    }
}
