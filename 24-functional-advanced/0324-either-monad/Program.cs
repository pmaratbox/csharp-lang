static Either<string, int> Divide(int a, int b) =>
    b == 0 ? Either<string, int>.Left("err") : Either<string, int>.Right(a / b);

var ok = Divide(8, 2).Bind(x => Divide(x, 2));      // 8/2=4, 4/2=2
var bad = Divide(8, 0).Bind(x => Divide(x, 2));     // err

Console.WriteLine($"{ok.Show()} {bad.Show()}");

readonly struct Either<L, R>
{
    private readonly L _left;
    private readonly R _right;
    public bool IsRight { get; }
    private Either(L left, R right, bool isRight) { _left = left; _right = right; IsRight = isRight; }
    public static Either<L, R> Left(L l) => new(l, default!, false);
    public static Either<L, R> Right(R r) => new(default!, r, true);

    public Either<L, TR> Bind<TR>(Func<R, Either<L, TR>> f) =>
        IsRight ? f(_right) : Either<L, TR>.Left(_left);

    public string Show() => IsRight ? _right!.ToString()! : _left!.ToString()!;
}
