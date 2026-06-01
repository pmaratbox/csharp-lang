using System.Globalization;

int n = int.Parse("42");
double f = double.Parse("3.5", CultureInfo.InvariantCulture);
string s = n.ToString();
Console.WriteLine($"int: {n}");
Console.WriteLine($"float: {f.ToString(CultureInfo.InvariantCulture)}");
Console.WriteLine($"str: {s}");
