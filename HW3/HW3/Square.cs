namespace HW3
{
    class Square : IFigure
    {
        private string _width;
        private string _length;
        public Square(string width, string length)
        {
            this._width = width;
            this._length = length;
        }
        public string Name => "Square";

        public string Width => this._width;

        public string Length => this._length;
    }
}
