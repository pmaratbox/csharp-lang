var stack = new MinStack();
foreach (var v in new[] { 3, 1, 2 }) stack.Push(v);
Console.WriteLine($"min: {stack.GetMin()}");

class MinStack
{
    private readonly Stack<int> _values = new();
    private readonly Stack<int> _mins = new();

    public void Push(int value)
    {
        _values.Push(value);
        _mins.Push(_mins.Count == 0 ? value : Math.Min(value, _mins.Peek()));
    }

    public int GetMin() => _mins.Peek();
}
