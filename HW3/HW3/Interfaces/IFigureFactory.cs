using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    interface IFigureFactory
    {
        IFigure CreateInstance(string description, string width, string length);
    }
}
