using System;
using System.Reflection;

namespace HW3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Использование абстрактной фабрики
            //IFigureFactory figureFactory = LoadFactory();
            //IFigure[] figures = {   figureFactory.CreateInstance("Circle", "3", "3"),
            //                        figureFactory.CreateInstance("Square", "2", "2"),
            //                        figureFactory.CreateInstance("Rectangle", "4", "8"),
            //                        figureFactory.CreateInstance("Dodecaedron","6", "6")
            //                    };
            //foreach (IFigure figure in figures)
            //{
            //    Console.WriteLine($"Фигура: {figure.GetType()}, {figure}");
            //}
            //Console.ReadLine();

            //Использование фабричного метода
            ICreator[] figures =    {   new CircleCreator("3","3"),
                                        new SquareCreator("2","2"),
                                        new RectangleCreator("4","8")
                                    };

            foreach (ICreator figure in figures)
            {
                Console.WriteLine($"Фигура: {figure.GetType()}, {figure.Create()}");
            }
            Console.ReadLine();
        }

        private static IFigureFactory LoadFactory()
        {
            string factoryName = Properties.Settings.Default.DefaultFigureFactory;
            return Assembly.GetExecutingAssembly().CreateInstance(factoryName) as IFigureFactory;
        }
    }
}
