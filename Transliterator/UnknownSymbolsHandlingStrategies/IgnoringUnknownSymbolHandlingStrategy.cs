namespace Transliterator.UnknownSymbolsHandlingStrategies
{
    public class IgnoringUnknownSymbolHandlingStrategy : IUnknownSymbolHandlingStrategy
    {
        public bool TryHandleUnknownSymbol(char c, out string relatedLetter)
        {
            relatedLetter = default(string);
            return false;
        }
    }
}