using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParProgrammeringLeviAndViktor
{
    internal class ClothingItem : InventoryItem, ISellable
    {
        public string Size { get; private set; }
        public string Color { get; private set; }

        public ClothingItem(string name, int quantity, double price, string size, string color) : base(name, quantity, price)
        {
            Size = size;
            Color = color;
        }

        public double CalculatePriceWithTax()
        {
            throw new NotImplementedException();
        }

        public double CalculatePriceWithDiscount()
        {
            throw new NotImplementedException();
        }
    }
}
