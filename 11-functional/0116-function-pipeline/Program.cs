Func<int, int> Pipe(params Func<int, int>[] fs) =>
    x => fs.Aggregate(x, (acc, f) => f(acc));

Func<int, int> inc = x => x + 1;
Func<int, int> dbl = x => x * 2;
Func<int, int> neg = x => -x;

var pipeline = Pipe(inc, dbl, neg);

Console.WriteLine(pipeline(3));
