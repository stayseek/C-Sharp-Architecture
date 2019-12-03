using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7
{
    public class ShippingCostCalculator
    {
        public double Calculate(Order order, IShippingStrategy shippingStrategy)
        {
            return shippingStrategy.Calculate(order);
        }
    }
}
