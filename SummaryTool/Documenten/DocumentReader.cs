using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SummaryTool.Documenten
{
    public class DocumentReader
    {
        public string ReadText()
        {
            Console.WriteLine("\nVoer de tekst in die je wilt samenvatten:");
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Fout: Geen tekst ingevoerd. Probeer het opnieuw.");
                return string.Empty;
            }

            Console.WriteLine("\n--- Originele tekst --- ");
            Console.WriteLine(input);
            Console.WriteLine("------------------------\n");

            return input;
        }
    }

}
