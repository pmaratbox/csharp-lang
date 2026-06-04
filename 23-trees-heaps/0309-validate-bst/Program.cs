static bool IsBst(Node? n, long low, long high) =>
    n is null || (n.Value > low && n.Value < high
        && IsBst(n.Left, low, n.Value)
        && IsBst(n.Right, n.Value, high));

static bool Valid(Node root) => IsBst(root, long.MinValue, long.MaxValue);

var good = new Node(5, new Node(3, new Node(1), new Node(4)), new Node(8));
var bad = new Node(5, new Node(3, new Node(1), new Node(6)), new Node(8));

Console.WriteLine($"{(Valid(good) ? "yes" : "no")} {(Valid(bad) ? "yes" : "no")}");

sealed record Node(int Value, Node? Left = null, Node? Right = null);
