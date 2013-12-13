using System.Collections.Generic;
using System.Text;

namespace Transliterator
{
    public class FromLatinToAnotherLanguageTransliterator : ITransliterator
    {
        public FromLatinToAnotherLanguageTransliterator(IEnumerable<KeyValuePair<string, char>> transliterationTable)
        {
            tree = new InvertedIndexTree();
            tree.Load(transliterationTable);
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