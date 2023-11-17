using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingListApp.Model
{
    public class ShoppingLists
    {
        public int ShoppingListsId { get; set; }
        public Shopper Shopper { get; set; }
        public Item Item { get; set; }
    }
}
