using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SummaryTool.DocumentReader
{
    public class DocumentReader
    {
        // Leest tekst uit een bestand
        public string ReadDocument(string pad)
        {
            return File.ReadAllText(pad);
        }

        // Leest directe tekstinvoer uit de console
        public string ReadText(string invoer)
        {
            return invoer;
        }
    }

}
