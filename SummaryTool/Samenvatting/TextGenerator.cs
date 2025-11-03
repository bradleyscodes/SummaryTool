using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SummaryTool.Samenvatting
{
    public class TextGenerator
    {
        public string GenerateSummary(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return "Fout: Geen tekst beschikbaar om samen te vatten.";
            }

            int halfLength = text.Length / 2;
            return text.Substring(0, halfLength) + "(samenvatting)";
            }
        }
    }
