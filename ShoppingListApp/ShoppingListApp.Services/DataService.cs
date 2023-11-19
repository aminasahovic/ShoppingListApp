using ShoppingListApp.Model;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingListApp.Services
{
    public interface IDataService
    {
        void GenerateData();
    }

    public class DataService : IDataService
    {
        private readonly ShoppingListDbContext context;

        public DataService(ShoppingListDbContext context)
        {
            this.context= context;
        }
        public void GenerateData()
        {
            var Shopper=new List<Shopper>();
            var Item=new List<Item>();


            Shopper.Add(new Shopper { FirstName = "Emily", LastName = "Smith", });
            Shopper.Add(new Shopper { FirstName = "Michael", LastName = "Johnson", });
            Shopper.Add(new Shopper { FirstName = "Sarah", LastName = "Williams", });
            Shopper.Add(new Shopper { FirstName = "Christopher", LastName = "Brown", });
            Shopper.Add(new Shopper { FirstName = "Olivia", LastName = "Jones", });

            Item.Add(new Item { Name = "Laptop" });
            Item.Add(new Item { Name = "Keyboard" });
            Item.Add(new Item { Name = "USB" });
            Item.Add(new Item { Name = "Headphones" });
            Item.Add(new Item { Name = "Smart Phone" });

            context.AddRange(Shopper);
            context.AddRange(Item);

            context.SaveChanges();

        }
    }
}
