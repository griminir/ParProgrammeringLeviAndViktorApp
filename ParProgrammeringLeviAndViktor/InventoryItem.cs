using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParProgrammeringLeviAndViktor
{
    public abstract class InventoryItem
    {
        public string Name { get; private set; }
        public int Quantity { get; private set; }
        public double Price { get; private set; }

        protected InventoryItem(string name, int quantity, double price)
        {
            Name = name;
            Quantity = quantity;
            Price = price;
        }
    }
}
