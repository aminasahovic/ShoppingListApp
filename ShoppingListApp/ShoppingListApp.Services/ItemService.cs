using Microsoft.EntityFrameworkCore;
using ShoppingListApp.Model;

namespace ShoppingListApp.Services
{

    public interface IItemService
    {
        List<Item> GetItem();
        List<Item> GetByShopper(int shopperId);

    }
    public class ItemService : IItemService
    {
        private readonly ShoppingListDbContext context;

        public ItemService(ShoppingListDbContext context)
        {
            this.context = context;
        }

        public List<Item> GetByShopper(int shopperId)
        {
            var shopper = context.Shopper.Find(shopperId);
            return context.Item.Where(item => !context.ShoppingLists.Any(list => list.Item == item && list.Shopper == shopper)).ToList();
        }

        public List<Item> GetItem()
        {
            return context.Item.ToList();
        }
    }


}