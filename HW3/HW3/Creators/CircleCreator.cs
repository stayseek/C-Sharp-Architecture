namespace HW3
{
    class CircleCreator : ICreator
    {
        Circle circle;

        public CircleCreator(string width, string length)
        {
            circle = new Circle(width, length);
        }
        public IFigure Create() => circle;
    }
}
