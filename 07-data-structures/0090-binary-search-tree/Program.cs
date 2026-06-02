var root = (Node?)null;
foreach (var v in new[] { 5, 3, 8, 1, 4 })
{
    root = Insert(root, v);
}

var output = new List<int>();
Inorder(root, output);
Console.WriteLine(string.Join(" ", output));

static Node Insert(Node? root, int value)
{
    if (root == null) return new Node(value);
    if (value < root.Value) root.Left = Insert(root.Left, value);
    else root.Right = Insert(root.Right, value);
    return root;
}

static void Inorder(Node? root, List<int> output)
{
    if (root == null) return;
    Inorder(root.Left, output);
    output.Add(root.Value);
    Inorder(root.Right, output);
}

class Node
{
    public int Value;
    public Node? Left;
    public Node? Right;
    public Node(int value) { Value = value; }
}
