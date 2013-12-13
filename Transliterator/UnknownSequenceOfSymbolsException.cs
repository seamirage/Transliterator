using System;

namespace Transliterator
{
    public class UnknownSequenceOfSymbolsException : Exception
    {
        public UnknownSequenceOfSymbolsException(char unknownSymbol, int index)
            : base("Unknown sequence of symbols, starts from: " + unknownSymbol + " at position: " + index)
        {
        }
    }
}
