Shape shape = new Circle(new Red());
Console.WriteLine(shape.Describe());

interface IColor { string Name(); }

sealed class Red : IColor { public string Name() => "red"; }

abstract class Shape
{
    protected readonly IColor Color;
    protected Shape(IColor color) => Color = color;
    public abstract string Describe();
}

sealed class Circle : Shape
{
    public Circle(IColor color) : base(color) { }
    public override string Describe() => $"{Color.Name()} circle";
}
