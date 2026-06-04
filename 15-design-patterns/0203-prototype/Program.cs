var original = new Prototype { Value = 1 };
var clone = original.Clone();
clone.Value = 2;
Console.WriteLine($"{original.Value} {clone.Value}");

sealed class Prototype
{
    public int Value { get; set; }
    public Prototype Clone() => new Prototype { Value = Value };
}
