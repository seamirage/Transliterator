using System.Collections.Generic;
using System.Linq;

namespace Transliterator
{
    public static class UrlTransliterationTable
    {
        public static IDictionary<char, string> RussianToLatin = 
            new Dictionary<string, char>
                {
                    {"a", 'а'},
                    {"b", 'б'},
                    {"v", 'в'},
                    {"g", 'г'},
                    {"d", 'д'},
                    {"e", 'е'},
                    {"yo", 'ё'},
                    {"zh", 'ж'},
                    {"z", 'з'},
                    {"i", 'и'},
                    {"j", 'й'},
                    {"k", 'к'},
                    {"l", 'л'},
                    {"m", 'м'},
                    {"n", 'н'},
                    {"o", 'о'},
                    {"p", 'п'},
                    {"r", 'р'},
                    {"s", 'с'},
                    {"t", 'т'},
                    {"u", 'у'},
                    {"f", 'ф'},
                    {"h", 'х'},
                    {"c", 'ц'},
                    {"ch", 'ч'},
                    {"sh", 'ш'},
                    {"shh", 'щ'},
                    {"'", 'ь'},
                    {"y", 'ы'},
                    {"._", 'ъ'},
                    {"e-", 'э'},
                    {"yu", 'ю'},
                    {"ya", 'я'},
                    {"_", ' '}
                }.ToDictionary(x => x.Value, y => y.Key);

        public static IDictionary<string, char> LatinToRussian =
            new Dictionary<string, char>
                {
                    {"a", 'а'},
                    {"b", 'б'},
                    {"v", 'в'},
                    {"g", 'г'},
                    {"d", 'д'},
                    {"e", 'е'},
                    {"yo", 'ё'},
                    {"zh", 'ж'},
                    {"z", 'з'},
                    {"i", 'и'},
                    {"j", 'й'},
                    {"k", 'к'},
                    {"l", 'л'},
                    {"m", 'м'},
                    {"n", 'н'},
                    {"o", 'о'},
                    {"p", 'п'},
                    {"r", 'р'},
                    {"s", 'с'},
                    {"t", 'т'},
                    {"u", 'у'},
                    {"f", 'ф'},
                    {"h", 'х'},
                    {"c", 'ц'},
                    {"ch", 'ч'},
                    {"sh", 'ш'},
                    {"shh", 'щ'},
                    {"'", 'ь'},
                    {"y", 'ы'},
                    {"._", 'ъ'},
                    {"e-", 'э'},
                    {"yu", 'ю'},
                    {"ya", 'я'},
                    {"_", ' '}
                };
    }
}
