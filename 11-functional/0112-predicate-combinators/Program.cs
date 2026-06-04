Func<int, bool> And(Func<int, bool> p, Func<int, bool> q) => x => p(x) && q(x);

Func<int, bool> isEven = x => x % 2 == 0;
Func<int, bool> isPositive = x => x > 0;

var test = And(isEven, isPositive);

Console.WriteLine($"{(test(4) ? "yes" : "no")} {(test(-4) ? "yes" : "no")}");
