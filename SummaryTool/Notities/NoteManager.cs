using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummaryTool.Notities
{
    public class NoteManager
    {   
      public string AddNotes(string summary)
      {
        Console.WriteLine("Wil je nog een notitie toevoegen? (j/n)");
        string choice = Console.ReadLine().ToLower();

            if ( choice == "j")
            {
                Console.Write("Voer je notitie in: ");
                string note = Console.ReadLine();
                return summary + "\nNotitie: " + note;
            }

            return summary;
        }

    }
}
