static Node? Insert(Node? root, int v)
{
    if (root is null) return new Node(v);
    if (v < root.Value) root.Left = Insert(root.Left, v);
    else root.Right = Insert(root.Right, v);
    return root;
}

static bool Search(Node? root, int v)
{
    while (root is not null)
    {
        if (v == root.Value) return true;
        root = v < root.Value ? root.Left : root.Right;
    }
    return false;
}

Node? bst = null;
foreach (var v in new[] { 5, 3, 8, 1, 4 }) bst = Insert(bst, v);

Console.WriteLine($"{(Search(bst, 4) ? "yes" : "no")} {(Search(bst, 6) ? "yes" : "no")}");

sealed class Node(int value)
{
    public int Value = value;
    public Node? Left, Right;
}
