var nodes = new INode[] { new Leaf(1), new Leaf(2), new Leaf(3) };
var visitor = new SumVisitor();
foreach (var node in nodes)
    node.Accept(visitor);
Console.WriteLine(visitor.Total);

interface INode { void Accept(IVisitor visitor); }

interface IVisitor { void Visit(Leaf leaf); }

sealed class Leaf : INode
{
    public int Value { get; }
    public Leaf(int value) => Value = value;
    public void Accept(IVisitor visitor) => visitor.Visit(this);
}

sealed class SumVisitor : IVisitor
{
    public int Total { get; private set; }
    public void Visit(Leaf leaf) => Total += leaf.Value;
}
