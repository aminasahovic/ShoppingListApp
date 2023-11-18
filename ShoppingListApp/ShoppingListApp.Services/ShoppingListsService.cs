using ShoppingListApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingListApp.Services
{
    public interface IShoppingListsService
    {
        void AddItems(int shopperId, List<Item> items);
    }
    public class ShoppingListsService : IShoppingListsService
    {
        private readonly ShoppingListDbContext context;

        public ShoppingListsService(ShoppingListDbContext context)
        {
            this.context = context;
        }

        public void AddItems(int shopperId, List<Item> items)
        {
            foreach (var item in items)
            {
                var newItem = new ShoppingLists()
                {
                    Shopper = context.Shopper.Find(shopperId),
                    Item = item
                };
                context.ShoppingLists.Add(newItem);
                var itm = item;
                itm.Quantity--;
                context.Update(itm);
                context.SaveChanges();
            }
        }
    }
}
