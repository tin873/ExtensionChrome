using PCS.Extension.Data.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace PCS.Extension.Service
{
    public class ExchangeToVND
    {
        public async Task<List<Currency>> DeserializeJson()
        {
            // Folder, where a file is created.  
            // Make sure to change this folder to your own folder  
            string folder = Directory.GetCurrentDirectory();
            // Filename  
            string fileName = "SaveJson\\InfomationInContext.json";

            // Fullpath. You can direct hardcode it if you like. 
            // Read a file  
            string fullPath = Path.Combine(folder, fileName);

            using FileStream openStream = File.OpenRead(fullPath);
            List<Currency> lstLeague =
                await JsonSerializer.DeserializeAsync<List<Currency>>(openStream);

            return lstLeague;
        }
    }
}
