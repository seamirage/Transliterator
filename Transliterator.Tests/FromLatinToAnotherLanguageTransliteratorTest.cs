using System;
using System.Collections.Generic;
using NUnit.Framework;

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
        [TestCase("pod._em", "подъем")]
        [TestCase("shh", "щ")]
        [TestCase("", "")]
        [TestCase("1-komnatnaya_kvartira", "1-комнатная квартира")]
        public void TestIt(string english, string expectedRussian)
        {
            Test(english, expectedRussian);
        }

        [Test]
        [TestCase(".")]
        [TestCase("fgdkl*")]
        [ExpectedException(typeof(UnknownSequenceOfSymbolsException))]
        public void PointTest(string incorrectText)
        {
            Test(incorrectText, "");
        }

        private static void Test(string englishText, string expectedRussianText)
        {
            FromLatinToAnotherLanguageTransliterator transliterator = new FromLatinToAnotherLanguageTransliterator(UrlTransliterationTable.LatinToRussian);
            var russianString = transliterator.Transliterate(englishText);
            Assert.AreEqual(expectedRussianText, russianString);
        }

        [Test]
        public void IndexTreeJS()
        {
            InvertedIndexTree tree = new InvertedIndexTree();
            tree.Load(UrlTransliterationTable.LatinToRussian);
            tree.PrintForJS();
        }

        [Test]
        public void TransliterationTable()
        {
            Console.WriteLine("{");
            foreach (KeyValuePair<char, string> relation in UrlTransliterationTable.RussianToLatin)
            {
                Console.WriteLine("" + "'"+ relation.Key+"' :" + "'" + relation.Value + "' ,");
            }
            Console.WriteLine("}");
        }
    }
}
