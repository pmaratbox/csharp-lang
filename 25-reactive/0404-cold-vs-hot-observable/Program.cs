using System.Globalization;

// Cold observable: each subscribe runs the producer independently.
var cold = new Observable<int>(observer =>
{
    observer.Next(1);
    observer.Next(2);
    observer.Next(3);
    observer.Complete();
});

var coldA = new List<int>();
var coldB = new List<int>();
cold.Subscribe(new Observer<int>(coldA.Add));
cold.Subscribe(new Observer<int>(coldB.Add));

Console.WriteLine("cold A: " + Join(coldA));
Console.WriteLine("cold B: " + Join(coldB));

// Hot observable: one shared producer; emissions are driven externally.
// Late subscribers only see values emitted after they subscribe.
var hot = new Subject<int>();
var hotA = new List<int>();
var hotB = new List<int>();

hot.Subscribe(new Observer<int>(hotA.Add)); // A subscribes first
hot.Next(1);                                 // only A is listening
hot.Subscribe(new Observer<int>(hotB.Add)); // B subscribes late
hot.Next(2);                                 // both receive
hot.Next(3);                                 // both receive
hot.Complete();

Console.WriteLine("hot A: " + Join(hotA));
Console.WriteLine("hot B: " + Join(hotB));

static string Join(List<int> xs) =>
    string.Join(" ", xs.Select(x => x.ToString(CultureInfo.InvariantCulture)));

// --- from-scratch reactive primitives (no System.Reactive) ---

sealed class Observer<T>
{
    private readonly Action<T> _next;
    private readonly Action? _complete;
    public Observer(Action<T> next, Action? complete = null)
    {
        _next = next;
        _complete = complete;
    }
    public void Next(T value) => _next(value);
    public void Complete() => _complete?.Invoke();
}

// Cold: subscribing invokes the producer fresh for each observer.
sealed class Observable<T>
{
    private readonly Action<Observer<T>> _producer;
    public Observable(Action<Observer<T>> producer) => _producer = producer;
    public void Subscribe(Observer<T> observer) => _producer(observer);
}

// Hot: a single shared execution multicast to current subscribers.
sealed class Subject<T>
{
    private readonly List<Observer<T>> _observers = new();
    public void Subscribe(Observer<T> observer) => _observers.Add(observer);
    public void Next(T value)
    {
        foreach (var o in _observers) o.Next(value);
    }
    public void Complete()
    {
        foreach (var o in _observers) o.Complete();
    }
}
