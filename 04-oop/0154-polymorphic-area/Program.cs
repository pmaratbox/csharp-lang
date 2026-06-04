using System.Globalization;

IShape[] shapes = [new Rectangle(2, 3), new Triangle(4, 4)];
double total = shapes.Sum(s => s.Area());
Console.WriteLine($"total area: {total.ToString(CultureInfo.InvariantCulture)}");

interface IShape
{
    double Area();
}

class Rectangle(double width, double height) : IShape
{
    public double Area() => width * height;
}

class Triangle(double @base, double height) : IShape
{
    public double Area() => @base * height / 2;
}
