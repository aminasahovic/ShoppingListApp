using Microsoft.EntityFrameworkCore;
using ShoppingListApp.Model;

namespace ShoppingListApp.Services
{

    public interface IItemService
    {
        List<Item> GetItem();
    }
    public class ItemService : IItemService
    {
        private readonly ShoppingListDbContext context;

        public ItemService(ShoppingListDbContext context)
        {
            this.context = context;
        }


        public List<Item> GetItem()
        {
            return context.Item.ToList();
        }
    }


}