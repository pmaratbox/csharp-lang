var expr = "1 + 2";
var tokens = new List<string>();
foreach (var ch in expr)
{
    if (char.IsDigit(ch)) tokens.Add("NUM");
    else if (ch == '+') tokens.Add("PLUS");
}
Console.WriteLine(string.Join(' ', tokens));
