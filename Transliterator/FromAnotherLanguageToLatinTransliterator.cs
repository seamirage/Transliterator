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
                string translit = transliterationTable[c];
                sb.Append(translit);
            }

            return sb.ToString();
        }

        private readonly IDictionary<char, string> transliterationTable;
    }
}
