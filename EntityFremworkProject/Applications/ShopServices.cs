using EntityFremworkProject.Infrastructure;
using EntityFremworkProject.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFremworkProject.Applications
{
    public class ShopServices : IShopServices
    {
        private readonly ApplicationDbContext _context;
        public ShopServices(ApplicationDbContext context)
        {
            _context = context;
        }


        public async Task<string> CreateShopAsync(Shop shop)
        {
            await _context.AddAsync(shop);
            await _context.SaveChangesAsync();
            return "Information joined❗";
        }

        public async Task<bool> DeleteShopAsync(int id)
        {
            var x = _context.shops.FirstOrDefaultAsync(s => s.Id == id);
            if (x != null)
            {
                _context.Remove(x.Result);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<List<Shop>> GetAllShopAsync()
        {
            var x = _context.shops.ToList();
            await _context.SaveChangesAsync();
            return x;
        }

        public Task<Shop> GetShopByIdAsync(int id)
        {
            var x = _context.shops.FirstOrDefaultAsync(s => s.Id == id);
            if (x != null)
            {
                return x;
            }
            return null;
        }

        public async Task<Shop> UpdateShopAsync(int id, Shop shop)
        {
            var x = _context.shops.FirstOrDefaultAsync(s => s.Id == id);
            if (x != null)
            {
                x.Result.Name = shop.Name;
                x.Result.Address = shop.Address;
                await _context.SaveChangesAsync();
                return x.Result;
            }
            return null;
        }


    }
}
