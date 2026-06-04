var stack = new Stack<int>();
foreach (var tok in "3 4 + 5 *".Split(' '))
{
    if (int.TryParse(tok, out var n)) { stack.Push(n); continue; }
    var b = stack.Pop();
    var a = stack.Pop();
    stack.Push(tok switch
    {
        "+" => a + b,
        "-" => a - b,
        "*" => a * b,
        "/" => a / b,
        _ => throw new InvalidOperationException(tok),
    });
}
Console.WriteLine(stack.Pop());
