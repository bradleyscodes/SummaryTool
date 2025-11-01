using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SummaryTool.Opslag
{
    public class Database
    {
        private string storeDocument = "samenvatting.txt";

        // Saves the summary locally
        public void SaveSummary(string text)
        {
            File.WriteAllText(storeDocument, text);
        }

        // Retrieves the saved summary

        public string GetSummary()
        {
            if (File.Exists(storeDocument))
            {
                return File.ReadAllText(storeDocument);
            }
            return string.Empty;
        }
    }
}
