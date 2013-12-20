namespace Transliterator.UnknownSymbolsHandlingStrategies
{
    public interface IUnknownSymbolHandlingStrategy
    {
        bool TryHandleUnknownSymbol(char c, out string relatedLetter);
    }
}
