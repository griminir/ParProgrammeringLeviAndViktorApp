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
        public string SalesPitch => $"we have {Quantity} of the {Name} in the size {Size} and color {Color}";

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


        public void DisplayItem()
        {
            var seal_price = CalculatePriceWithTax();
            var seal_discount = CalculatePriceWithDiscount();
           
            Console.WriteLine($"{SalesPitch} the price is : {seal_price} kr . with discounts {seal_discount} kr");
        }




    }
}
