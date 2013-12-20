using NUnit.Framework;
using Transliterator.UnknownSymbolsHandlingStrategies;

namespace Transliterator.Tests
{
    [TestFixture]
    public class FromLatinToAnotherLanguageTransliteratorTest
    {
        [TestCase("shapka", "шапка")]
        [TestCase("kesh", "кеш")]
        [TestCase("lada_kalina", "лада калина")]
        [TestCase("Zaglavnaya", "заглавная")]
        [TestCase("yolka", "ёлка")]
        [TestCase("char", "чар")]
        [TestCase("car'", "царь")]
        [TestCase("prodam_dachu_s_banej_i_pech'yu_v_port_arture", "продам дачу с баней и печью в порт артуре")]
        [TestCase("e-kran", "экран")]
        [TestCase("pod^em", "подъем")]
        [TestCase("shh", "щ")]
        [TestCase("", "")]
        [TestCase("1-komnatnaya_kvartira", "1-комнатная квартира")]
        [TestCase("bmw", "бмw")]
        public void TestIt(string english, string expectedRussian)
        {
            Test(english, expectedRussian);
        }

        [Test]
        [TestCase("%")]
        [TestCase("fl*")]
        [ExpectedException(typeof(UnknownSequenceOfSymbolsException))]
        public void IncorrectSymbolsTest(string incorrectText)
        {
            Test(incorrectText, "");
        }

        private static void Test(string englishText, string expectedRussianText)
        {
            FromLatinToAnotherLanguageTransliterator transliterator = new FromLatinToAnotherLanguageTransliterator(TransliterationTable.UrlLatinToRussian, new ThrowsExceptionUnknownSymbolHandlingStrategy());
            var russianString = transliterator.Transliterate(englishText);
            Assert.AreEqual(expectedRussianText, russianString);
        }
    }
}
