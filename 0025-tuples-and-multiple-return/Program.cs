(int lo, int hi) MinMax(int a, int b) => a < b ? (a, b) : (b, a);

var (lo, hi) = MinMax(3, 7);
Console.WriteLine($"min: {lo}");
Console.WriteLine($"max: {hi}");
