int RecursiveSum(ReadOnlySpan<int> xs) =>
    xs.IsEmpty ? 0 : xs[0] + RecursiveSum(xs[1..]);

Console.WriteLine(RecursiveSum([1, 2, 3, 4]));
