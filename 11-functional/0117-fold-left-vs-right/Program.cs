int[] xs = [1, 2, 3];

int FoldLeft(int seed, IEnumerable<int> items, Func<int, int, int> f) =>
    items.Aggregate(seed, f);

int FoldRight(IEnumerable<int> items, int seed, Func<int, int, int> f) =>
    items.Reverse().Aggregate(seed, (acc, x) => f(x, acc));

int left = FoldLeft(0, xs, (acc, x) => acc - x);
int right = FoldRight(xs, 0, (x, acc) => x - acc);

Console.WriteLine($"{left} {right}");
