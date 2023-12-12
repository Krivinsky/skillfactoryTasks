using Xunit;

namespace Translator.Tests
{
    public class TranslateServiceTests
    {
        [Fact]
        public void GetTranslationMustBeReturnCorrectValue()
        {
            var translateService = new TranslateService();
            translateService.AddTranslation("orange", "апельсин");

            Assert.Equal("апельсин", translateService.GetTranslation("orange"));

        }
    }
}