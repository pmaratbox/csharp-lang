int diameter = 0;

int Depth(Node? n)
{
    if (n is null) return 0;
    int l = Depth(n.Left), r = Depth(n.Right);
    diameter = Math.Max(diameter, l + r);
    return 1 + Math.Max(l, r);
}

var c = new Node("C");
var d = new Node("D");
var a = new Node("A", c, d);
var b = new Node("B");
var root = new Node("root", a, b);

Depth(root);
Console.WriteLine(diameter);

sealed record Node(string Name, Node? Left = null, Node? Right = null);
