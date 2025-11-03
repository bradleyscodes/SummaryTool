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
            Console.WriteLine("Welkom bij SummaryTool!");

            var reader = new DocumentReader();
            var generator = new TextGenerator();
            var notes = new NoteManager();

            // Vraag en toon tekst
            string originalText = reader.ReadText();

            // Vraag of gebruiker wil samenvatten
            Console.WriteLine("Wil je deze tekst samenvatten? (j/n)");
            string response = Console.ReadLine().ToLower();

            string summary = originalText;
            if (response == "j")
            {
                summary = generator.GenerateSummary(originalText);
                Console.WriteLine("\n--- Samenvatting --- ");
                Console.WriteLine(summary);
                Console.WriteLine("---------------------\n");
            }

            // Voeg notities toe
            summary = notes.AddNotes(summary);

            Console.WriteLine("\nWat wil je doen met de samenvatting?");
            Console.WriteLine("1 - Opslaan");
            Console.WriteLine("2 - Bekijken wat er eerder is opgeslagen");
            Console.WriteLine("3 - Afsluiten");
            Console.WriteLine("Keuze: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                 case "1":
                    var db = new Database();
                    db.SaveSummary(summary);
                    break;
                case "2":
                    var dbRead = new Database();
                    dbRead.Read();
                    break;
                case "3":
                    Console.WriteLine("Programma afgesloten.");
                    break;
                default:
                    Console.WriteLine("Programma afgesloten zonder opslaan.");
                    break;
            }

            Console.WriteLine("\nDruk op een toets om af te sluiten...");
            Console.ReadKey();

        }
    }
}
