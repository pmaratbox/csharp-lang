int a = 3, b = 5;
a ^= b;
b ^= a;
a ^= b;
Console.WriteLine($"{a} {b}");
