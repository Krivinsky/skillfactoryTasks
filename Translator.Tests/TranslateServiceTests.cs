using Xunit;

namespace Translator.Tests
{
    public class TranslateServiceTests
    {
        [Fact]
        public void GetTranslationMustBeReturnCorrectValue()
        {
            var translateService = new TranslateService();
            translateService.AddTranslation("orange", "��������");

            Assert.Equal("��������", translateService.GetTranslation("orange"));

        }
    }
}