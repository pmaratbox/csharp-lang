Func<int, Func<int, int>> add = a => b => a + b;

Console.WriteLine(add(2)(3));
