static Node? Insert(Node? root, int v)
{
    if (root is null) return new Node(v);
    if (v < root.Value) root.Left = Insert(root.Left, v);
    else root.Right = Insert(root.Right, v);
    return root;
}

static int Height(Node? n) =>
    n is null ? 0 : 1 + Math.Max(Height(n.Left), Height(n.Right));

Node? bst = null;
foreach (var v in new[] { 5, 3, 8, 1, 4 }) bst = Insert(bst, v);

Console.WriteLine(Height(bst));

sealed class Node(int value)
{
    public int Value = value;
    public Node? Left, Right;
}
