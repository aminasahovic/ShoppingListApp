using Microsoft.AspNetCore.Mvc;
using ShoppingListApp.Model;
using ShoppingListApp.Services;

namespace ShoppingListApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShopperController : ControllerBase
    {
        private readonly IShopperService service;
        public ShopperController(IShopperService service)
        {
            this.service=service;
        }

        [HttpGet]
        public List<Shopper> GetAll()
        {
            return service.GetAll();
        }
    }
}