using NUnit.Framework;
using Transliterator.Russian;

namespace Transliterator.Tests
{
    [TestFixture]
    public class FromLatinToRussianTransliteratorTest
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
        [TestCase("pod._em", "подъем")]
        public void TestIt(string english, string expectedRussian)
        {
            Test(english, expectedRussian);
        }

        private static void Test(string englishText, string expectedRussianText)
        {
            FromLatinToRussianTransliterator transliterator = new FromLatinToRussianTransliterator();
            var str = transliterator.Transliterate(englishText);
            Assert.AreEqual(expectedRussianText, str);
        }
    }
}
