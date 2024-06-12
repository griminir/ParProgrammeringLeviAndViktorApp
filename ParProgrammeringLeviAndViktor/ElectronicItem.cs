using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ParProgrammeringLeviAndViktor
{
    internal class ElectronicItem : InventoryItem, ISellable
    {
        public string InsuranceInfo { get; private set; }
        public int Voltage { get; private set; }
        public string SalesPitch => $"we have {Quantity} of the {Name} in the with a warranty of {InsuranceInfo} and and it uses {Voltage} Volt";

        public decimal CalculatePriceWithTax()
        {
            decimal tax_rate = Price * 0.25m;
            return Price + tax_rate;
        }

        public decimal CalculatePriceWithDiscount()
        {
            decimal before_discount = CalculatePriceWithTax();
            return before_discount * 0.5m;
        }

        public ElectronicItem(string name, int quantity, decimal price, string insurance, int voltage) : base(name, quantity, price)
        {
            InsuranceInfo = insurance;
            Voltage = voltage;
        }

        public void DisplayItem()
        {
            var seal_price = CalculatePriceWithTax();
            var seal_discount = CalculatePriceWithDiscount();

            Console.WriteLine($"{SalesPitch} the price is : {seal_price} kr . with discounts {seal_discount} kr");
        }
    }
}
