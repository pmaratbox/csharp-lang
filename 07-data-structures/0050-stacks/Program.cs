var stack = new Stack<int>();
for (int n = 1; n <= 3; n++)
{
    stack.Push(n);
}

var popped = new List<int>();
while (stack.Count > 0)
{
    popped.Add(stack.Pop());
}

Console.WriteLine(string.Join(" ", popped));
