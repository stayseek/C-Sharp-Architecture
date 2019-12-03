using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7
{
    public class Order
    {
        public ShippingOptions ShippingMethod { set; get; }
        public Address Destination { set; get; }
        public Address Origin { set; get; }
    }
}
