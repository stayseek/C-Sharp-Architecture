namespace HW3
{
    class RectangleCreator:ICreator
    {
        Rectangle rectangle;

        public RectangleCreator(string width, string length)
        {
            rectangle = new Rectangle(width, length);
        }
        public IFigure Create() => rectangle;
    }
}
