var emitter = new EventEmitterPubsub();

void H(string payload) => Console.WriteLine($"hi {payload}");
void G(string payload) => Console.WriteLine($"bye {payload}");

emitter.On("greet", H);
emitter.On("bye", G);

emitter.Emit("greet", "ada");
emitter.Emit("bye", "ada");

emitter.Off("greet", H);
emitter.Emit("greet", "x"); // handler removed -> nothing

sealed class EventEmitterPubsub
{
    private readonly Dictionary<string, List<Action<string>>> _topics = new();

    public void On(string topic, Action<string> handler)
    {
        if (!_topics.TryGetValue(topic, out var handlers))
        {
            handlers = new List<Action<string>>();
            _topics[topic] = handlers;
        }
        handlers.Add(handler);
    }

    public void Emit(string topic, string payload)
    {
        if (_topics.TryGetValue(topic, out var handlers))
        {
            foreach (var handler in handlers.ToArray())
                handler(payload);
        }
    }

    public void Off(string topic, Action<string> handler)
    {
        if (_topics.TryGetValue(topic, out var handlers))
            handlers.Remove(handler);
    }
}
