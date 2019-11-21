namespace HW3
{
    class Circle : IFigure
    {
        private string _width;
        private string _length;
        public Circle(string width, string length)
        {
            this._width = width;
            this._length = length;
        }
        public string Name => "Circle";

        public string Width => this._width;

        public string Length => this._length;

        public override string ToString() => $"{Name}, Диаметр: {this.Width}";

    }
}
