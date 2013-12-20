using System.Collections.Generic;
using System.Text;
using Transliterator.UnknownSymbolsHandlingStrategies;

namespace Transliterator
{
    public class FromLatinToAnotherLanguageTransliterator : ITransliterator
    {
        public FromLatinToAnotherLanguageTransliterator(IEnumerable<KeyValuePair<string, char>> transliterationTable, IUnknownSymbolHandlingStrategy unknownSymbolHandlingStrategy)
        {
            this.unknownSymbolHandlingStrategy = unknownSymbolHandlingStrategy;
            tree = new InvertedIndexTree();
            tree.Load(transliterationTable);
        }

        public virtual string Transliterate(string englishText)
        {
            englishText = englishText.ToLower();

            StringBuilder sb = new StringBuilder();
            int index = 0;
            while (index < englishText.Length)
            {
                char letter;
                if (tree.TrySearchMaxOccurence(englishText, ref index, out letter))
                {
                    sb.Append(letter);                                   
                }
                else
                {
                    HandleUnknownLetter(englishText[index], sb);
                    ++index;
                }
            }

            return sb.ToString();
        }

        private void HandleUnknownLetter(char unknownLetter, StringBuilder sb)
        {
            string relatedLetter;
            if (unknownSymbolHandlingStrategy.TryHandleUnknownSymbol(unknownLetter, out relatedLetter))
            {
                sb.Append(relatedLetter);
            }
        }

        private InvertedIndexTree tree;
        private IUnknownSymbolHandlingStrategy unknownSymbolHandlingStrategy;
    }
}