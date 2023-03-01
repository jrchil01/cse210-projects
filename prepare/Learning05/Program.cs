using System;

class Program
{
    static void Main(string[] args)
    {
        Square squareTest = new Square("red", 5);
        Console.WriteLine(squareTest.GetArea());
        Console.WriteLine(squareTest.GetColor());

        Rectangle rectangleTest = new Rectangle("blue", 4, 3);
        Console.WriteLine(rectangleTest.GetArea());
        Console.WriteLine(rectangleTest.GetColor());

        Circle circleTest = new Circle("yellow", 6);
        Console.WriteLine(circleTest.GetArea());
        Console.WriteLine(circleTest.GetColor());

        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square("purple", 2));
        shapes.Add(new Rectangle("green", 5, 6));
        shapes.Add(new Circle("orange", 3));

        foreach(Shape shape in shapes)
        {
            Console.WriteLine($"This shapes is {shape.GetColor()} and has an area of {shape.GetArea()}");
        }
    }
}