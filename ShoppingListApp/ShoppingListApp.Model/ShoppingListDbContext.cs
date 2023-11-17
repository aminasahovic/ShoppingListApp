using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingListApp.Model
{
    public class ShoppingListDbContext: DbContext
    {
        public ShoppingListDbContext(DbContextOptions<ShoppingListDbContext> options) : base(options)
        {

        }
        public DbSet<Item> Item { get; set; }
        public DbSet<Shopper> Shopper { get; set; }
        public DbSet<ShoppingLists> ShoppingLists { get; set; }

    }
}
