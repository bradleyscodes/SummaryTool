using System;

namespace SummaryTool
{
    internal class Program
    {
        static void Main()
        {
            var reader = new DocumentReader();

            string input = reader.ReadDocument("voorbeeld.txt");
            Console.WriteLine("Inhoud van het document:" + input);

            string text = reader.ReadFromConsole();
        }
    }
}
