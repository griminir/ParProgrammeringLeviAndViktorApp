using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParProgrammeringLeviAndViktor
{
    public interface ISellable
    {
        public decimal CalculatePriceWithTax();
        public decimal CalculatePriceWithDiscount();
        public void DisplayItem();
    }
}
