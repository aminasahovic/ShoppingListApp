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
        public IActionResult AddList(int shopperId, List<Item> itemsId)
        {
            return Ok(service.AddItems(shopperId, itemsId));

        }

        [HttpGet("{shopperId}")]
        public List<ShoppingLists> GetListByShopperr(int shopperId)
        {
            return service.GetItemsByShopper(shopperId);
        }

        [HttpDelete("{listId}")]
        public IActionResult DeleteListItem(int listId)
        {
            return Ok(service.DeleteListItem(listId));
        }

    }
}