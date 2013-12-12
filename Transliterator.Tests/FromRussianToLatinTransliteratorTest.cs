using NUnit.Framework;
using Transliterator.Russian;

namespace Transliterator.Tests
{
    [TestFixture]
    public class FromRussianToLatinTransliteratorTest
    {
        [TestCase("щука", "shhuka")]
        [TestCase("экран", "e-kran")]
        public void TestIt(string russianText, string expectedLatinText)
        {
            FromRussianToLatinTransliterator transliterator = new FromRussianToLatinTransliterator();
            string latinText = transliterator.Transliterate(russianText);
            Assert.AreEqual(expectedLatinText, latinText);
        }
    }
}
