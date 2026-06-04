var subject = new Subject();
subject.Subscribe(new PrintingObserver("obs1"));
subject.Subscribe(new PrintingObserver("obs2"));
subject.Notify(5);

interface IObserver { void Update(int value); }

sealed class PrintingObserver : IObserver
{
    private readonly string _id;
    public PrintingObserver(string id) => _id = id;
    public void Update(int value) => Console.WriteLine($"{_id}: {value}");
}

sealed class Subject
{
    private readonly List<IObserver> _observers = new();
    public void Subscribe(IObserver observer) => _observers.Add(observer);
    public void Notify(int value)
    {
        foreach (var o in _observers)
            o.Update(value);
    }
}
