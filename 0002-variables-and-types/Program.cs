using System.Globalization;

int n = 42;
double pi = 3.14;
string greeting = "hello";
bool flag = true;

Console.WriteLine($"int: {n}");
Console.WriteLine($"float: {pi.ToString(CultureInfo.InvariantCulture)}");
Console.WriteLine($"string: {greeting}");
Console.WriteLine($"bool: {flag}");
