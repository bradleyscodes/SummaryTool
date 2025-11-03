using Xunit;
using SummaryTool.Samenvatting;

namespace SummaryTool.Tests
{
    public class TextGeneratorTests
    {
        [Fact]
        public void GenerateSummary_ReturnsShorterText()
        {
            // Arrange (voorbereiding)
            var generator = new TextGenerator();
            string input = "Dit is een voorbeeldzin om te testen of de samenvatting korter wordt";

            // Act (actie)
            string summary = generator.GenerateSummary(input);

            // Assert (controle)

            Assert.False(string.IsNullOrWhiteSpace(summary)); // samenvatting mag niet leeg zijn
            Assert.True(summary.Length < input.Length); // samenvatting moet korter zijn dan de originele tekst
        }
    }
}
