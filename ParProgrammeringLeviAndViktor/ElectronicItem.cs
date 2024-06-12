using System;
using System.Collections.Generic;
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

        public ElectronicItem(string name, int quantity, decimal price, string inscurance, int voltage) : base(name, quantity, price)
        {
            InsuranceInfo = inscurance;
            Voltage = voltage;
        }
    }
}
