static Node? Insert(Node? root, int v)
{
    if (root is null) return new Node(v);
    if (v < root.Value) root.Left = Insert(root.Left, v);
    else root.Right = Insert(root.Right, v);
    return root;
}

static Node? Delete(Node? root, int v)
{
    if (root is null) return null;
    if (v < root.Value) root.Left = Delete(root.Left, v);
    else if (v > root.Value) root.Right = Delete(root.Right, v);
    else
    {
        if (root.Left is null) return root.Right;
        if (root.Right is null) return root.Left;
        var succ = root.Right;
        while (succ.Left is not null) succ = succ.Left;
        root.Value = succ.Value;
        root.Right = Delete(root.Right, succ.Value);
    }
    return root;
}

static void InOrder(Node? n, List<int> acc)
{
    if (n is null) return;
    InOrder(n.Left, acc);
    acc.Add(n.Value);
    InOrder(n.Right, acc);
}

Node? bst = null;
foreach (var v in new[] { 5, 3, 8, 1, 4 }) bst = Insert(bst, v);
bst = Delete(bst, 3);

var result = new List<int>();
InOrder(bst, result);
Console.WriteLine(string.Join(" ", result));

sealed class Node(int value)
{
    public int Value = value;
    public Node? Left, Right;
}
