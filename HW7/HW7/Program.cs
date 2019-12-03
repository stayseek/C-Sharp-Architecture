using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7
{
    class Program
    {
        static void Main(string[] args)
        {
            IShippingStrategy UPSShippingStrategy = new UPSStrategy();
            IShippingStrategy FedExShippingStrategy = new FedExStrategy();
            IShippingStrategy EMSShippingStrategy = new EMSStrategy();

            var shippingCalculator = new ShippingCostCalculator();

            Console.WriteLine($"UPS shipping cost: {shippingCalculator.Calculate(new Order(), UPSShippingStrategy)}");
            Console.WriteLine($"FedEx shipping cost: {shippingCalculator.Calculate(new Order(), FedExShippingStrategy)}");
            Console.WriteLine($"EMS shipping cost: {shippingCalculator.Calculate(new Order(), EMSShippingStrategy)}");
            Console.ReadLine();
        }
    }
}
