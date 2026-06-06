// A from-scratch push-based Observable. An observer is just a callback for "next".
// map(source, f) wraps a source so each emitted value is transformed by f.

static Observable<int> FromValues(params int[] values) =>
    new Observable<int>(onNext =>
    {
        foreach (var v in values) onNext(v);
    });

static Observable<TOut> Map<TIn, TOut>(Observable<TIn> source, Func<TIn, TOut> f) =>
    new Observable<TOut>(onNext => source.Subscribe(value => onNext(f(value))));

var source = FromValues(1, 2, 3, 4);
var doubled = Map(source, x => x * 2);
doubled.Subscribe(Console.WriteLine);

sealed class Observable<T>
{
    private readonly Action<Action<T>> _produce;
    public Observable(Action<Action<T>> produce) => _produce = produce;
    public void Subscribe(Action<T> onNext) => _produce(onNext);
}
