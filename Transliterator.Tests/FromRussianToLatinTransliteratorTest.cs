using System;
using System.Collections.Generic;
using NUnit.Framework;
using Transliterator.UnknownSymbolsHandlingStrategies;

namespace Transliterator.Tests
{
    [TestFixture]
    public class FromAnotherLanguageToLatinTransliteratorTest
    {
        [TestCase("щука", "shhuka")]
        [TestCase("экран", "e-kran")]
        [TestCase("один-кран", "odin-kran")]
        public void TestIt(string russianText, string expectedLatinText)
        {
            FromAnotherLanguageToLatinTransliterator transliterator = new FromAnotherLanguageToLatinTransliterator(TransliterationTable.UrlRussianToLatin, new ThrowsExceptionUnknownSymbolHandlingStrategy());
            string latinText = transliterator.Transliterate(russianText);
            Assert.AreEqual(expectedLatinText, latinText);
        }
    }
}