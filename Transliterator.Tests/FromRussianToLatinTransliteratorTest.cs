using NUnit.Framework;

namespace Transliterator.Tests
{
    [TestFixture]
    public class FromAnotherLanguageToLatinTransliteratorTest
    {
        [TestCase("щука", "shhuka")]
        [TestCase("экран", "e-kran")]
        public void TestIt(string russianText, string expectedLatinText)
        {
            FromAnotherLanguageToLatinTransliterator transliterator = new FromAnotherLanguageToLatinTransliterator(UrlTransliterationTable.RussianToLatin);
            string latinText = transliterator.Transliterate(russianText);
            Assert.AreEqual(expectedLatinText, latinText);
        }
    }
}
