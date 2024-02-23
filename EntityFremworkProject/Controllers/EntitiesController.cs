using EntityFremworkProject.Applications;
using EntityFremworkProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EntityFremworkProject.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EntitiesController : ControllerBase
    {
        private readonly IShopServices _services;
        public EntitiesController(IShopServices services)
        {
            _services = services;
        }

        [HttpPost]
        public async Task<string> CreateShop(Shop Model)
        {
            var result = await _services.CreateShopAsync(Model);
            return result;
        }

        [HttpGet]
        public async Task<List<Shop>> GetAllShopAsync()
        {
            var resilt = await _services.GetAllShopAsync();
            return resilt;
        }

        [HttpGet]
        public async Task<Shop> GetShopByIdAsync(int id)
        {
            var resilt = await _services.GetShopByIdAsync(id);
            return resilt;
        }


        [HttpDelete]
        public async Task<bool> DeleteShopAsync(int id)
        {
            var result = await _services.DeleteShopAsync(id);
            return result;
        }



        [HttpPatch]
        public async Task<Shop> UpdateShopAsync(int id, Shop shop)
        {
            var resilt = await _services.UpdateShopAsync(id, shop);
            return resilt;
        }
    }
}
