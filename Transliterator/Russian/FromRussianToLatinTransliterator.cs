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
            : this(new Dictionary<string, char>
                       {
                           {"a", 'à'},
                           {"b", 'á'},
                           {"v", 'â'},
                           {"g", 'ã'},
                           {"d", 'ä'},
                           {"e", 'å'},
                           {"yo", '¸'},
                           {"zh", 'æ'},
                           {"z", 'ç'},
                           {"i", 'è'},
                           {"j", 'é'},
                           {"k", 'ê'},
                           {"l", 'ë'},
                           {"m", 'ì'},
                           {"n", 'í'},
                           {"o", 'î'},
                           {"p", 'ï'},
                           {"r", 'ð'},
                           {"s", 'ñ'},
                           {"t", 'ò'},
                           {"u", 'ó'},
                           {"f", 'ô'},
                           {"h", 'õ'},
                           {"c", 'ö'},
                           {"ch", '÷'},
                           {"sh", 'ø'},
                           {"shh", 'ù'},
                           {"'", 'ü'},
                           {"y", 'û'},
                           {"._", 'ú'},
                           {"e-", 'ý'},
                           {"yu", 'þ'},
                           {"ya", 'ÿ'},
                           {"_", '_'}
                       }.ToDictionary(x => x.Value, y => y.Key)
                )
        {}
    }
}