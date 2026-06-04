var head = new Node(1);
var mid = new Node(2);
var tail = new Node(3);
head.Next = mid; mid.Prev = head;
mid.Next = tail; tail.Prev = mid;

var forward = new List<int>();
for (Node? n = head; n is not null; n = n.Next) forward.Add(n.Value);
Console.WriteLine(string.Join(" ", forward));

var backward = new List<int>();
for (Node? n = tail; n is not null; n = n.Prev) backward.Add(n.Value);
Console.WriteLine(string.Join(" ", backward));

class Node(int value)
{
    public int Value = value;
    public Node? Prev;
    public Node? Next;
}
