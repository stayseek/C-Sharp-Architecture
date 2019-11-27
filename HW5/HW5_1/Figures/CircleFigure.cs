using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace HW5_1
{
    class CircleFigure : IDrawAPI
    {

        private int _defaultRadius = 32;
        public static int ObjectCounter = 0;
        public CircleFigure()
        {
            ObjectCounter++;
        }
        public string Name => "Circle";

        public void DrawAt(int posX, int posY)
        {
            DrawingBoard.Buffer.Graphics.DrawEllipse(Pens.White, posX, posY, _defaultRadius, _defaultRadius);
            DrawingBoard.Draw();
        }

    }
}
