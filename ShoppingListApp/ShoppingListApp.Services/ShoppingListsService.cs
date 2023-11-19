using Microsoft.EntityFrameworkCore;
using ShoppingListApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingListApp.Services
{
    public interface IShoppingListsService
    {
        bool AddItems(int shopperId, List<Item> items);
        List<ShoppingLists> GetItemsByShopper(int shopperId);

        bool DeleteListItem(int listId);
    }
    public class ShoppingListsService : IShoppingListsService
    {
        private readonly ShoppingListDbContext context;

        public ShoppingListsService(ShoppingListDbContext context)
        {
            this.context = context;
        }

        public bool AddItems(int shopperId, List<Item> items)
        {
            if (items != null && shopperId>0)
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
                return true;
            }
            return false;
            
        }

        public bool DeleteListItem(int listId)
        {

            if (listId == 0)
            {
                return false;
            }
            var list = context.ShoppingLists.Include(x => x.Item).Include(x => x.Shopper).FirstOrDefault(x => x.ShoppingListsId == listId);
            if (list == null)
            {

            }
            if (list.Item != null)
            {
                var itm = context.Item.Where(x => x.ItemId == list.Item.ItemId).FirstOrDefault();
                if (itm != null)
                {
                    itm.Quantity++;
                    context.Update(itm);
                }
            }

            context.ShoppingLists.Remove(list);
            context.SaveChanges();
            return true;
        }

        public List<ShoppingLists> GetItemsByShopper(int shopperId)
        {
            return context.ShoppingLists.Include(x => x.Item).Include(x => x.Shopper).Where(list => list.Shopper.ShopperId == shopperId).ToList();
        }
    }
}
