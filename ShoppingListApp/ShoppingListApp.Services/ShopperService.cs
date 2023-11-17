using ShoppingListApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingListApp.Services
{ 
    public interface IShopperService
    {
        List<Shopper> GetAll();
    }
    public class ShopperService : IShopperService
    {
        public readonly ShoppingListDbContext context;
        public ShopperService(ShoppingListDbContext context)
        {
            this.context = context;
        }

        public List<Shopper> GetAll()
        {
            return context.Shopper.ToList();
        }
    }
}
