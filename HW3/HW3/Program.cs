using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    class Program
    {
        static void Main(string[] args)
        {
            FigureFactory figureFactory = new FigureFactory();
            IFigure[] figures = {   figureFactory.CreateInstance("Circle", "3", "3"),
                                    figureFactory.CreateInstance("Square", "2", "2"),
                                    figureFactory.CreateInstance("Rectangle", "4", "8"),
                                    figureFactory.CreateInstance("Dodecaedron","6", "6")
                                };
        }
    }
}
