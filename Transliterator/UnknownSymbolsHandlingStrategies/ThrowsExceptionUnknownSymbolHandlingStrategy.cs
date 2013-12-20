namespace Transliterator.UnknownSymbolsHandlingStrategies
{
    public class ThrowsExceptionUnknownSymbolHandlingStrategy : IUnknownSymbolHandlingStrategy
    {
        public bool TryHandleUnknownSymbol(char c, out string relatedLetter)
        {
            throw new UnknownSequenceOfSymbolsException(c);
        }
    }
}