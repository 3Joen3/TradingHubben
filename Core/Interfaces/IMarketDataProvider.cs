namespace Core.Interfaces
{
    public interface IMarketDataProvider
    {
        Task<decimal> GetCurrentPriceAsync(string symbol);
    }
}
