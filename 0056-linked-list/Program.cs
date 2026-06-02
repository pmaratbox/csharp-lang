var head = new Node(1, new Node(2, new Node(3)));

var parts = new List<string>();
for (Node? node = head; node != null; node = node.Next)
{
    parts.Add(node.Value.ToString());
}
Console.WriteLine(string.Join(" -> ", parts));

class Node
{
    public int Value;
    public Node? Next;
    public Node(int value, Node? next = null)
    {
        Value = value;
        Next = next;
    }
}
