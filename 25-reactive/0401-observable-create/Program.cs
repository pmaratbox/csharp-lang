// A push-based Observable built from scratch: subscribe wires a producer
// to an observer with next/complete callbacks. No System.Reactive used.

var source = new Observable<int>(observer =>
{
    observer.Next(1);
    observer.Next(2);
    observer.Next(3);
    observer.Complete();
});

source.Subscribe(new Observer<int>(
    next: value => Console.WriteLine(value),
    complete: () => Console.WriteLine("done")));

sealed class Observer<T>
{
    private readonly Action<T> _next;
    private readonly Action _complete;

    public Observer(Action<T> next, Action complete)
    {
        _next = next;
        _complete = complete;
    }

    public void Next(T value) => _next(value);
    public void Complete() => _complete();
}

sealed class Observable<T>
{
    private readonly Action<Observer<T>> _subscribe;

    public Observable(Action<Observer<T>> subscribe) => _subscribe = subscribe;

    public void Subscribe(Observer<T> observer) => _subscribe(observer);
}
