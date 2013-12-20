using System.Collections.Generic;
using System.Text;
using Transliterator.UnknownSymbolsHandlingStrategies;

namespace Transliterator
{
    public class FromAnotherLanguageToLatinTransliterator : ITransliterator
    {
        public FromAnotherLanguageToLatinTransliterator(IDictionary<char, string> transliterationTable, IUnknownSymbolHandlingStrategy unknownSymbolHandlingStrategy)
        {
            this.transliterationTable = transliterationTable;
            this.unknownSymbolHandlingStrategy = unknownSymbolHandlingStrategy;
        }

        public string Transliterate(string russianText)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in russianText)
            {
                if (transliterationTable.ContainsKey(c))
                {
                    string translit = transliterationTable[c];
                    sb.Append(translit);   
                }
                else
                {
                    string resolvedTranslit;
                    if (unknownSymbolHandlingStrategy.TryHandleUnknownSymbol(c, out resolvedTranslit))
                    {
                        sb.Append(resolvedTranslit);
                    }
                }
            }

            return sb.ToString();
        }

        private readonly IDictionary<char, string> transliterationTable;
        private readonly IUnknownSymbolHandlingStrategy unknownSymbolHandlingStrategy;
    }
}
