using System.Collections.Generic;
using System.Text;

namespace Transliterator
{
    public class FromEnglishToRussianTransliterator
    {
        public FromEnglishToRussianTransliterator()
        {
            tree = new InvertedIndexTree();
            foreach (var relation in relations)
            {
                tree.Add(relation.Key, relation.Value);
            }
        }

        public string Transliterate(string englishText)
        {
            StringBuilder sb = new StringBuilder();
            int index = 0;
            while (index < englishText.Length)
            {
                var letter = tree.SearchMaxOccurence(englishText, ref index);
                sb.Append(letter);
            }

            return sb.ToString();
        }


        private Dictionary<string, char> relations = new Dictionary<string, char>
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
                                                         };

        private InvertedIndexTree tree;
    }
}