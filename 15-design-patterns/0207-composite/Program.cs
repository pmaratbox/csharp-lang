var root = new Composite();
root.Add(new Leaf(1));
root.Add(new Leaf(2));
root.Add(new Leaf(3));
Console.WriteLine(root.Size());

interface IComponent { int Size(); }

sealed class Leaf : IComponent
{
    private readonly int _value;
    public Leaf(int value) => _value = value;
    public int Size() => _value;
}

sealed class Composite : IComponent
{
    private readonly List<IComponent> _children = new();
    public void Add(IComponent child) => _children.Add(child);
    public int Size() => _children.Sum(c => c.Size());
}
