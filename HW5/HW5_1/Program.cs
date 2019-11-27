using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Reflection;

namespace HW5_1
{
    //Реализовать шаблон «Приспособленец» при отображении на экране окружностей и прямоугольников в приложении Windows Forms.
    static class Program
    {
        static private readonly Random random = new Random();

        const int TEXTOFFSET = 64;
        const int MAXHEIGTHOFFSET = 32;
        const int MAXWIDTHOFFSET = 32;



        [STAThread]
        static void Main()
        {
            Form form = new Form();
            form.Width = 800;
            form.Height = 600;
            DrawingBoard.Init(form);
            form.Show();
            //DrawingBoard.Draw();

            //Использование абстрактной фабрики
            IFigureFactory figureFactory = LoadFactory();

            for (int i = 0; i < 20; i++)
            {
                IDrawAPI circle = figureFactory.GetFigure("CircleFigure");
                circle.DrawAt(random.Next(0, DrawingBoard.Width- MAXWIDTHOFFSET), random.Next(TEXTOFFSET, DrawingBoard.Height- MAXHEIGTHOFFSET));
            }

            for (int i = 0; i < 20; i++)
            {
                IDrawAPI circle = figureFactory.GetFigure("SquareFigure");
                circle.DrawAt(random.Next(0, DrawingBoard.Width- MAXWIDTHOFFSET), random.Next(TEXTOFFSET, DrawingBoard.Height- MAXHEIGTHOFFSET));
            }

            for (int i = 0; i < 20; i++)
            {
                IDrawAPI circle = figureFactory.GetFigure("RectangleFigure");
                circle.DrawAt(random.Next(0, DrawingBoard.Width- MAXWIDTHOFFSET), random.Next(TEXTOFFSET, DrawingBoard.Height- MAXHEIGTHOFFSET));
            }

            DrawingBoard.Buffer.Graphics.DrawString($"Circle instances:{CircleFigure.ObjectCounter}" +
                                                    $"\nSquare instances:{SquareFigure.ObjectCounter}" +
                                                    $"\nRectangle instances:{RectangleFigure.ObjectCounter}",
                                                    SystemFonts.DefaultFont,
                                                    Brushes.White,
                                                    0, 0);
            DrawingBoard.Draw();
            Application.Run(form);
        }

        private static IFigureFactory LoadFactory()
        {
            string factoryName = Properties.Settings.Default.DefaultFigureFactory;
            return Assembly.GetExecutingAssembly().CreateInstance(factoryName) as IFigureFactory;
        }
    }
}
