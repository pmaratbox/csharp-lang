Func<int, int> inc = x => x + 1;
Func<int, int> twice = x => x * 2;
Func<int, int> compose(Func<int, int> f, Func<int, int> g) => x => f(g(x));

Console.WriteLine(compose(inc, twice)(3));
