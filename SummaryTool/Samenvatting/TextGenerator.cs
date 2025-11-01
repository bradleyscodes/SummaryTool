using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummaryTool.Samenvatting
{
    public class TextGenerator
    {
        public string GenerateSummary(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return "";

            int length = text.Length / 2;
            return text.Substring(0, length) + "...";

        }
    }
}
