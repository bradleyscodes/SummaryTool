using SummaryTool.Documenten;
using SummaryTool.Notities;
using SummaryTool.Opslag;
using SummaryTool.Samenvatting;
using System;

namespace SummaryTool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var reader = new DocumentReader();
            var generator = new TextGenerator();
            var notities = new NoteManager();
            var database = new Database();

            Console.WriteLine("Enter text to be summarized:");
            string input = Console.ReadLine();

            // Read text
            string text = reader.ReadText(input);

            // Generate summary
            string summary = TextGenerator.GenerateSummary(text);

            Console.WriteLine("Summary:");
            Console.WriteLine(summary);

            // Optionally add a note
            Console.WriteLine("Would you like to add a note? (yes/no)");
            if (Console.ReadLine().ToLower() == "yes")
            {
                Console.Write("Notitie: ");
                string note = Console.ReadLine();
                summary = notities.AddNote(summary, note);
                Console.WriteLine("Updated Summary with Note:");
                Console.WriteLine(summary);
            }

            // Save summary
            database.SaveSummary(summary);

            Console.WriteLine("Summary saved in 'summary.txt'");
            Console.WriteLine("Press aby key to exit...";
            Console.ReadKey();
        }
    }
}
