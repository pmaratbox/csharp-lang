static int Prec(string op) => op switch { "+" or "-" => 1, "*" or "/" => 2, _ => 0 };

var output = new List<string>();
var ops = new Stack<string>();
foreach (var tok in "3 + 4 * 2".Split(' '))
{
    if (int.TryParse(tok, out _)) output.Add(tok);
    else
    {
        while (ops.Count > 0 && Prec(ops.Peek()) >= Prec(tok))
            output.Add(ops.Pop());
        ops.Push(tok);
    }
}
while (ops.Count > 0) output.Add(ops.Pop());
Console.WriteLine(string.Join(' ', output));
