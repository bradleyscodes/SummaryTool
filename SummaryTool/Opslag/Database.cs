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

        private readonly string _fileName = "samenvatting.txt";

        //Slaat de samenvatting (met notities) op in een bestand
        public void SaveSummary(string text)
        {
            File.WriteAllText(_fileName, text);
            Console.WriteLine($"\nSamenvatting opgeslagen in {_fileName}");
        }

        public void Read()
        {
            if (File.Exists(_fileName))
            {
                Console.WriteLine("\n--- Opgeslagen samenvatting ---");
                Console.WriteLine(File.ReadAllText(_fileName));
                Console.WriteLine("-------------------------------");
            }
            else
            {
                Console.WriteLine($"Er is nog geen samenvatting opgeslagen.");
            }

        }



    }
}
