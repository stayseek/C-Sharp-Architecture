namespace HW3
{
    class Rectangle : IFigure
    {
        private string _width;
        private string _length;
        public Rectangle(string width, string length)
        {
            this._width = width;
            this._length = length;
        }
        public string Name => "Rectangle";

        public string Width => this._width;

        public string Length => this._length;

        public override string ToString() => $"{Name}, Ширина: {this.Width}, Длина: {this.Length}";
    }
}
