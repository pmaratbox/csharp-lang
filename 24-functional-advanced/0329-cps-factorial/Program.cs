static T FactCps<T>(int n, Func<int, T> k) =>
    n == 0 ? k(1) : FactCps(n - 1, r => k(n * r));

Console.WriteLine(FactCps(5, x => x));
