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
        public double CalculatePriceWithTax()
        {
            throw new NotImplementedException();
        }

        public double CalculatePriceWithDiscount()
        {
            throw new NotImplementedException();
        }

        public ElectronicItem(string name, int quantity, double price, string inscurance, int voltage) : base(name, quantity, price)
        {
            InsuranceInfo = inscurance;
            Voltage = voltage;
        }
    }
}
