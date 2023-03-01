public class Rectangle : Shape
{
    int _length;
    int _width;
    public Rectangle(string color, int length, int width) : base(color)
    {
        _length = length;
        _width = width;
    }

    public override double GetArea()
    {
        return _length * _width;
    }
}