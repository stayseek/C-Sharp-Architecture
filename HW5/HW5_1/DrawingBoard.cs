using System;
using System.Windows.Forms;
using System.Drawing;

namespace HW5_1
{
    static class DrawingBoard
    {
        private static BufferedGraphicsContext _context;
        public static BufferedGraphics Buffer;
        public static int Width { set; get; }
        public static int Height { set; get; }

        static DrawingBoard()
        {
        }

        public static void Init(Form form)
        {
            Graphics graphics;
            _context = BufferedGraphicsManager.Current;
            graphics = form.CreateGraphics();
            Width = form.ClientSize.Width;
            Height = form.ClientSize.Height;
            Buffer = _context.Allocate(graphics, new Rectangle(0, 0, Width, Height));
        }

        public static void Draw()
        {
            Buffer.Render();
        }
    }
}
