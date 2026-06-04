using System.Text;

const string unreserved = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789-_.~";

var input = "a b&c";
var sb = new StringBuilder();
foreach (var ch in input)
{
    if (unreserved.Contains(ch))
        sb.Append(ch);
    else
        sb.Append('%').Append(((int)ch).ToString("X2"));
}
Console.WriteLine(sb.ToString());
