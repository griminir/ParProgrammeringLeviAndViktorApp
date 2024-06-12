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

        public ClothingItem(string name, int quantity, decimal price, string size, string color) : base(name, quantity, price)
        {
            Size = size;
            Color = color;
        }

        public decimal CalculatePriceWithTax()
        {
            decimal tax_rate = Price * 0.1m;
            return Price + tax_rate;
        }

        public decimal CalculatePriceWithDiscount()
        {
            decimal price_with_tax = CalculatePriceWithTax();
            return price_with_tax * 0.7m;
        }


        public static ClothingItem DisplayClothingItem(string name, int quantity, decimal price, string size, string color)
        {
            var clothing_item = new ClothingItem(name, quantity, price, size, color);
            var seal_price = clothing_item.CalculatePriceWithTax();
            var seal_discount = clothing_item.CalculatePriceWithDiscount();
           
            Console.WriteLine($"sale price of the item named ({name}) is : {seal_price} kr . with discounts {seal_discount} kr");
            return clothing_item;
        }




    }
}
