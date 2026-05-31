using System.Globalization;

int a = 17;
int b = 5;

Console.WriteLine($"a + b: {a + b}");
Console.WriteLine($"a - b: {a - b}");
Console.WriteLine($"a * b: {a * b}");
Console.WriteLine(string.Create(CultureInfo.InvariantCulture, $"a / b: {(double)a / b}"));
Console.WriteLine($"a % b: {a % b}");
