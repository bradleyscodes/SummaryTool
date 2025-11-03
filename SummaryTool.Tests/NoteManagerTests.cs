using Xunit;
using SummaryTool.Notities;

namespace SummaryTool.Tests
{
    public class NoteManagerTests
    {
        [Fact]
        public void AddNotes_AddsNoteToSummary()
        {
            // Arrange (voorbereiding)
            var notes = new NoteManager();
            string summary = "Dit is een samenvatting.";
            
            using var input = new StringReader("ja\nTestnotitie\n");
            Console.SetIn(input);

            // Act (actie)
            string result = notes.AddNotes(summary);

            // Assert (controle)
            Assert.Contains("Testnotitie", result);
            Assert.Contains("Notitie", result);
        }
    }
}
