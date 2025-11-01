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
            var notities = new Notities.NoteManager();

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
        }
    }
}
