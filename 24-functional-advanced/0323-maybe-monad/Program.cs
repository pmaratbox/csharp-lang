var present = Maybe<int>.Some(2)
    .Bind(x => Maybe<int>.Some(x + 3))
    .Bind(x => Maybe<int>.Some(x * 2));

var absent = Maybe<int>.None
    .Bind(x => Maybe<int>.Some(x + 3))
    .Bind(x => Maybe<int>.Some(x * 2));

Console.WriteLine($"{present.Show("none")} {absent.Show("none")}");

readonly struct Maybe<T>
{
    private readonly T _value;
    public bool HasValue { get; }
    private Maybe(T value, bool has) { _value = value; HasValue = has; }
    public static Maybe<T> Some(T value) => new(value, true);
    public static readonly Maybe<T> None = new(default!, false);

    public Maybe<TR> Bind<TR>(Func<T, Maybe<TR>> f) => HasValue ? f(_value) : Maybe<TR>.None;
    public string Show(string fallback) => HasValue ? _value!.ToString()! : fallback;
}
