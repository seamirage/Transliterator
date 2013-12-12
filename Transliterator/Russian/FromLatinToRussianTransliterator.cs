using System.Collections.Generic;

namespace Transliterator.Russian
{
    public class FromLatinToRussianTransliterator : FromLatinToAnotherLanguageTransliterator
    {
        public FromLatinToRussianTransliterator(IEnumerable<KeyValuePair<string, char>> transliterationTable) : base(transliterationTable)
        {
        }

        public FromLatinToRussianTransliterator()
            : this(UrlTransliterationTable.LatinToRussian)
        {
        }
    }
}