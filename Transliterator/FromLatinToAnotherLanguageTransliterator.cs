using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Transliterator
{
    public class FromLatinToAnotherLanguageTransliterator : ITransliterator
    {
        public FromLatinToAnotherLanguageTransliterator(IEnumerable<KeyValuePair<string, char>> transliterationTable)
        {
            tree = new InvertedIndexTree();
            foreach (var relation in transliterationTable.OrderBy(x => x.Key))
            {
                tree.Add(relation.Key, relation.Value);
            }
        }

        public string Transliterate(string englishText)
        {
            englishText = englishText.ToLower();

            StringBuilder sb = new StringBuilder();
            int index = 0;
            while (index < englishText.Length)
            {
                var letter = tree.SearchMaxOccurence(englishText, ref index);
                sb.Append(letter);
            }

            return sb.ToString();
        }

        private InvertedIndexTree tree;
    }
}