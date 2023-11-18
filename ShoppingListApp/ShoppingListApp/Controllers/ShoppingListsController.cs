using Microsoft.AspNetCore.Mvc;
using ShoppingListApp.Model;
using ShoppingListApp.Services;

namespace ShoppingListApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShoppingListsController : ControllerBase
    {

        private readonly IShoppingListsService service;
        public ShoppingListsController(IShoppingListsService service)
        {
            this.service = service;
        }

        [HttpPost]
        public void AddList(int shopperId, List<Item> itemsId)
        {
            service.AddItems(shopperId, itemsId);
        }
    }
}