using System.Globalization;

// A minimal push-based Observable built from scratch.
// distinctUntilChanged forwards a value only when it differs from the
// previously forwarded value, so consecutive duplicates are dropped.

static Observable<T> FromValues<T>(params T[] values) =>
    new Observable<T>(observer =>
    {
        foreach (var v in values) observer.Next(v);
        observer.Complete();
    });

static Observable<T> DistinctUntilChanged<T>(Observable<T> source) =>
    new Observable<T>(observer =>
    {
        var hasLast = false;
        T? last = default;
        source.Subscribe(new Observer<T>(
            value =>
            {
                if (!hasLast || !EqualityComparer<T>.Default.Equals(value, last!))
                {
                    hasLast = true;
                    last = value;
                    observer.Next(value);
                }
            },
            observer.Complete));
    });

var source = FromValues(1, 1, 2, 2, 2, 3, 1);
DistinctUntilChanged(source).Subscribe(new Observer<int>(
    value => Console.WriteLine(value.ToString(CultureInfo.InvariantCulture)),
    () => { }));

sealed class Observer<T>(Action<T> next, Action complete)
{
    public void Next(T value) => next(value);
    public void Complete() => complete();
}

sealed class Observable<T>(Action<Observer<T>> subscribe)
{
    public void Subscribe(Observer<T> observer) => subscribe(observer);
}
