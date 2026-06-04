var table = new (int Value, string Symbol)[]
{
    (1000, "M"), (900, "CM"), (500, "D"), (400, "CD"),
    (100, "C"), (90, "XC"), (50, "L"), (40, "XL"),
    (10, "X"), (9, "IX"), (5, "V"), (4, "IV"), (1, "I"),
};

var n = 14;
var sb = new System.Text.StringBuilder();
foreach (var (value, symbol) in table)
    while (n >= value)
    {
        sb.Append(symbol);
        n -= value;
    }
Console.WriteLine(sb.ToString());
