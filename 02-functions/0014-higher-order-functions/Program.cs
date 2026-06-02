int Inc(int x) => x + 1;
int Double(int x) => x * 2;

int Apply(Func<int, int> f, int x) => f(x);

Console.WriteLine($"inc 5 = {Apply(Inc, 5)}");
Console.WriteLine($"double 5 = {Apply(Double, 5)}");
