﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7
{
    public class EMSStrategy : IShippingStrategy
    {
        public double Calculate(Order order)
        {
            return 5;
        }
    }
}
