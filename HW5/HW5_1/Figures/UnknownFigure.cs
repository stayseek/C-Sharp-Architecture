using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace HW5_1
{
    class UnknownFigure : IDrawAPI
    {
        public static int ObjectCounter = 0;
        public UnknownFigure()
        {
            ObjectCounter++;
        }
        public string Name => "UnknownFigure";

        public void DrawAt(int posX, int posY)
        {
        }
    }
}
