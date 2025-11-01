using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummaryTool.Notities
{
    public class NoteManager
    {   
        // Voegt een notitie toe aan de samenvatting
        public string AddNote(string samenvatting, string notitie)
        { 
            return samenvatting + "Notitie: " + notitie;

        }
    }
}
