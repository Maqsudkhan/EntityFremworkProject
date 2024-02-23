using EntityFremworkProject.Models;

namespace EntityFremworkProject.Applications
{
    public interface IShopServices
    {
        Task<string> CreateShopAsync(Shop shop);
        Task<List<Shop>> GetAllShopAsync();
        Task<Shop> UpdateShopAsync(int id,  Shop shop);
        Task<bool> DeleteShopAsync(int id);
        Task<Shop> GetShopByIdAsync(int id);
    }
}
