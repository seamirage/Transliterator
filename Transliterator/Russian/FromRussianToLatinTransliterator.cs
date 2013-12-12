using System.Collections.Generic;
using System.Linq;

namespace Transliterator.Russian
{
    public class FromRussianToLatinTransliterator : FromAnotherLanguageToLatinTransliterator
    {
        public FromRussianToLatinTransliterator(IDictionary<char, string> transliterationTable) : base(transliterationTable)
        {
        }

        public FromRussianToLatinTransliterator()
            : this(UrlTransliterationTable.RussianToLatin)
        {
        }
    }
}