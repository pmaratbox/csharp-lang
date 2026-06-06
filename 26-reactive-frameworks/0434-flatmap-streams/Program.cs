using System.Reactive.Linq;
using Microsoft.Reactive.Testing;

var scheduler = new TestScheduler();

// Outer emits 1@10, 2@20.
var outer = Observable.Merge(
    Observable.Timer(TimeSpan.FromTicks(10), scheduler).Select(_ => 1),
    Observable.Timer(TimeSpan.FromTicks(20), scheduler).Select(_ => 2));

// Map each outer value n to a timed inner emitting n at +5 and n*10 at +30,
// then mergeMap (SelectMany) all inner streams together.
outer.SelectMany(n => Observable.Merge(
        Observable.Timer(TimeSpan.FromTicks(5), scheduler).Select(_ => n),
        Observable.Timer(TimeSpan.FromTicks(30), scheduler).Select(_ => n * 10)))
    .Subscribe(Console.WriteLine);

scheduler.Start();
