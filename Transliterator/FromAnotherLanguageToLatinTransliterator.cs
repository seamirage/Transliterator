using System;
using System.Collections.Generic;
using System.Text;

namespace Transliterator
{
    public class FromAnotherLanguageToLatinTransliterator : ITransliterator
    {
        public FromAnotherLanguageToLatinTransliterator(IDictionary<char, string> transliterationTable)
        {
            this.transliterationTable = transliterationTable;
        }

        public string Transliterate(string russianText)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in russianText)
            {
                try
                {
                    string translit = transliterationTable[c];
                    sb.Append(translit);
                }
                catch (KeyNotFoundException ex)
                {
                    throw new KeyNotFoundException(string.Format("Can't find {0} in transliteration table. Code: {1}", c, (int)c), ex);
                }
            }

            return sb.ToString();
        }

        private readonly IDictionary<char, string> transliterationTable;
    }
}
