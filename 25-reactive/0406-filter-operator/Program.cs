// A from-scratch push-based Observable: subscribe wires a producer to an observer.
Observable<int> Range(int start, int count) => new(observer =>
{
    for (var i = 0; i < count; i++)
        observer.Next(start + i);
    observer.Complete();
});

// filter forwards a value only when the predicate holds.
Observable<int> Filter(Observable<int> source, Func<int, bool> pred) => new(observer =>
    source.Subscribe(new Observer<int>(
        value => { if (pred(value)) observer.Next(value); },
        observer.Complete)));

var evens = Filter(Range(1, 6), n => n % 2 == 0);
evens.Subscribe(new Observer<int>(n => Console.WriteLine(n), () => { }));

sealed class Observer<T>(Action<T> next, Action complete)
{
    public void Next(T value) => next(value);
    public void Complete() => complete();
}

sealed class Observable<T>(Action<Observer<T>> producer)
{
    public void Subscribe(Observer<T> observer) => producer(observer);
}
