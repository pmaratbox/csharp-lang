static Trampoline<int> Sum(int n, int acc) =>
    n == 0 ? new Trampoline<int>.Done(acc)
           : new Trampoline<int>.More(() => Sum(n - 1, acc + n));

Console.WriteLine(Sum(100, 0).Run());

abstract record Trampoline<T>
{
    public sealed record Done(T Value) : Trampoline<T>;
    public sealed record More(Func<Trampoline<T>> Next) : Trampoline<T>;

    public T Run()
    {
        var current = this;
        while (current is More m) current = m.Next();
        return ((Done)current).Value;
    }
}
