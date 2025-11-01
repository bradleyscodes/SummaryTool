using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummaryTool.DocumentReader
{
    public class DocumentReader
    {
        public string ReadDocument(string pad)
        {
            if (!File.Exists(pad))
            {
                throw new FileNotFoundException("Het opgegeven document is niet gevonden.", pad);
            }

            return File.ReadAllText(pad);
        }

        public string ReadFromConsole()
        {
            Console.WriteLine("Voer tekst in: ");
            return Console.ReadLine();
        }
    }
}
