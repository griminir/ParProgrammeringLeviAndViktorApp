using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParProgrammeringLeviAndViktor
{
    public interface ISellable
    {
        public double CalculatePriceWithTax();
        public double CalculatePriceWithDiscount();
    }
}
