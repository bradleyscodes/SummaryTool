using SummaryTool.Samenvatting;
using System;

namespace SummaryTool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var reader = new Documenten.DocumentReader();
            var generator = new Samenvatting.TextGenerator();
            
            Console.WriteLine("Enter text to be summarized:");
            string input = Console.ReadLine();

            // Lees tekst
            string text = reader.ReadText(input);

            // Maak samenvatting
            string summary = TextGenerator.GenerateSummary(text);

            Console.WriteLine("Summary:");
            Console.WriteLine(summary);
        }
    }
}
