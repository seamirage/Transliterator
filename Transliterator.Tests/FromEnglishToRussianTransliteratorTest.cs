using NUnit.Framework;

namespace Transliterator.Tests
{
    [TestFixture]
    public class FromEnglishToRussianTransliteratorTest
    {
        [TestCase("shapka", "шапка")]
        [TestCase("kash", "каш")]
        [TestCase("lada_kalina", "лада_калина")]
        [TestCase("prodam_dachu_s_banej_i_pech'yu_v_port_arture", "продам_дачу_с_баней_и_печью_в_порт_артуре")]
        public void TestIt(string english, string expectedRussian)
        {
            Test(english, expectedRussian);
        }

        private static void Test(string englishText, string expectedRussianText)
        {
            FromEnglishToRussianTransliterator transliterator = new FromEnglishToRussianTransliterator();
            var str = transliterator.Transliterate(englishText);
            Assert.AreEqual(expectedRussianText, str);
        }
    }
}
