using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace HW5_1
{
    class SquareFigure : IDrawAPI
    {
        private int _defaultSide = 32;

        public static int ObjectCounter = 0;
        public SquareFigure()
        {
            ObjectCounter++;
        }
        public string Name => "Square";

        public void DrawAt(int posX, int posY)
        {
            DrawingBoard.Buffer.Graphics.DrawRectangle(Pens.Blue, new Rectangle(posX, posY, _defaultSide, _defaultSide));
            DrawingBoard.Draw();
        }
    }
}
