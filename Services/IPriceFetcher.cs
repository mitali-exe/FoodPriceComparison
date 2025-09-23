using FoodPriceComparison.Models;

namespace FoodPriceComparison.Services
{
    public interface IPriceFetcher
    {
        Task<List<PlatformPrice>> GetPricesAsync(string dishName, string restaurantName);
    }
}
