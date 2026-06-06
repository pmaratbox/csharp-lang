# 0423 — EventEmitter (Pub/Sub)

Build a multi-topic EventEmitter with on(topic, handler), emit(topic, payload), and off(topic, handler). A `Dictionary<string, List<Action<string>>>` maps topics to handler lists in idiomatic C#.

## Run

    dotnet run
