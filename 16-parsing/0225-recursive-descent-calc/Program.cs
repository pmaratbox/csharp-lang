var src = "2+3*4";
var pos = 0;

int Expr()
{
    var value = Term();
    while (pos < src.Length && (src[pos] == '+' || src[pos] == '-'))
    {
        var op = src[pos++];
        var rhs = Term();
        value = op == '+' ? value + rhs : value - rhs;
    }
    return value;
}

int Term()
{
    var value = Factor();
    while (pos < src.Length && (src[pos] == '*' || src[pos] == '/'))
    {
        var op = src[pos++];
        var rhs = Factor();
        value = op == '*' ? value * rhs : value / rhs;
    }
    return value;
}

int Factor()
{
    var start = pos;
    while (pos < src.Length && char.IsDigit(src[pos])) pos++;
    return int.Parse(src[start..pos]);
}

Console.WriteLine(Expr());
