static Func<A, C> Compose<A, B, C>(Func<B, C> g, Func<A, B> f) => x => g(f(x));

Func<IEnumerable<int>, IEnumerable<int>> mapSquare = xs => xs.Select(x => x * x);
Func<IEnumerable<int>, int> sum = xs => xs.Sum();

var sumOfSquares = Compose(sum, mapSquare);

Console.WriteLine(sumOfSquares(new[] { 1, 2, 3 }));
