using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace HW5_1
{
    class RectangleFigure : IDrawAPI
    {
        private int _defaultWidth = 28;
        private int _defaultLength = 40;

        public static int ObjectCounter = 0;
        public RectangleFigure()
        {
            ObjectCounter++;
        }
        public string Name => "Rectangle";

        public void DrawAt(int posX, int posY)
        {
            DrawingBoard.Buffer.Graphics.DrawRectangle(Pens.Red, new Rectangle(posX, posY, _defaultLength, _defaultWidth));
            DrawingBoard.Draw();
        }
    }
}
