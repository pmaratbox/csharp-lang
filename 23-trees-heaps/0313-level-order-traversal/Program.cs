static Node? Insert(Node? root, int v)
{
    if (root is null) return new Node(v);
    if (v < root.Value) root.Left = Insert(root.Left, v);
    else root.Right = Insert(root.Right, v);
    return root;
}

Node? bst = null;
foreach (var v in new[] { 5, 3, 8, 1, 4 }) bst = Insert(bst, v);

var order = new List<int>();
var queue = new Queue<Node>();
if (bst is not null) queue.Enqueue(bst);
while (queue.Count > 0)
{
    var n = queue.Dequeue();
    order.Add(n.Value);
    if (n.Left is not null) queue.Enqueue(n.Left);
    if (n.Right is not null) queue.Enqueue(n.Right);
}

Console.WriteLine(string.Join(" ", order));

sealed class Node(int value)
{
    public int Value = value;
    public Node? Left, Right;
}
