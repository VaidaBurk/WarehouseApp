using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseApp
{
    class Warehouse
    {
        private List<string> Items = new List<string>();

        public void Add(string item)
        {
            Items.Add(item);
        }

        public void List()
        {
            int warehouseSize = Items.Count;
            if (warehouseSize > 0)
            {
                var GroupedItems = Items.GroupBy(item => item)
                .Select(group => new { item = group.Key, quantity = group.Count() });
                
                foreach (var group in GroupedItems)
                {
                    Console.WriteLine(group.item + ", quantity: " + group.quantity);
                }

                //Console.WriteLine(String.Join(", ", GroupedItems));    // .Join converts list to separate strings
            }
            else
            {
                Console.WriteLine("sorry, the warehouse is empty!");
            }
        }

        public void RemoveItem(string item)
        {
            if (!Items.Contains(item)) 
            {
                Console.WriteLine("sorry, no such item in the warehouse!");
            }
            else
            {
                int itemNo = Items.IndexOf(item);
                Items.RemoveAt(itemNo);
            }
        }
    }
}
