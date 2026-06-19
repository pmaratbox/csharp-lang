// Zip [1,2,3] with ["a","b","c"], formatting each pair as <n><s>, using LINQ's Zip (System.Linq, stdlib).
Console.WriteLine(string.Join(",", new[] { 1, 2, 3 }.Zip(new[] { "a", "b", "c" }, (n, s) => $"{n}{s}")));
