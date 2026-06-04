// Fixed-point combinator: Fix f = f (Fix f), expressed without named self-recursion in the factorial body.
static Func<int, int> Fix(Func<Func<int, int>, Func<int, int>> f)
{
    Func<int, int> g = null!;
    g = n => f(g)(n);
    return g;
}

var factorial = Fix(self => n => n == 0 ? 1 : n * self(n - 1));

Console.WriteLine(factorial(5));
