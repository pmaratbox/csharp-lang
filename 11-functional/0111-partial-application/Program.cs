int Add(int a, int b) => a + b;

Func<int, int> add10 = b => Add(10, b);

Console.WriteLine(add10(3));
