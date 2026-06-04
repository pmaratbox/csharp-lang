int ApplyTwice(Func<int, int> f, int x) => f(f(x));

int Inc(int n) => n + 1;

Console.WriteLine(ApplyTwice(Inc, 3));
