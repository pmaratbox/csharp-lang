using System.Reactive.Linq;
using Microsoft.Reactive.Testing;

var scheduler = new TestScheduler();

// source emits a@10, b@20, c@100, completes late at 140
var source = scheduler.CreateColdObservable(
    new Recorded<System.Reactive.Notification<string>>(10, System.Reactive.Notification.CreateOnNext("a")),
    new Recorded<System.Reactive.Notification<string>>(20, System.Reactive.Notification.CreateOnNext("b")),
    new Recorded<System.Reactive.Notification<string>>(100, System.Reactive.Notification.CreateOnNext("c")),
    new Recorded<System.Reactive.Notification<string>>(140, System.Reactive.Notification.CreateOnCompleted<string>())
);

// Rx.NET names "debounce" as Throttle: emit a value only after a quiet window of 30 ticks
var debounced = source.Throttle(TimeSpan.FromTicks(30), scheduler);

debounced.Subscribe(v => Console.WriteLine(v));

scheduler.Start();
