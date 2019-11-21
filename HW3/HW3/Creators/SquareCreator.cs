namespace HW3
{
    class SquareCreator:ICreator
    {
        Square square;

        public SquareCreator(string width, string length)
        {
            square = new Square(width, length);
        }
        public IFigure Create() => square;
    }
}
