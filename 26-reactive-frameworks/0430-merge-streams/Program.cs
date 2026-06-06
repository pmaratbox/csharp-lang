using System.Reactive.Linq;
using Microsoft.Reactive.Testing;

var s = new TestScheduler();

var a = Observable.Merge(
    Observable.Timer(TimeSpan.FromTicks(10), s).Select(_ => 1),
    Observable.Timer(TimeSpan.FromTicks(30), s).Select(_ => 3),
    Observable.Timer(TimeSpan.FromTicks(50), s).Select(_ => 5));

var b = Observable.Merge(
    Observable.Timer(TimeSpan.FromTicks(20), s).Select(_ => 2),
    Observable.Timer(TimeSpan.FromTicks(40), s).Select(_ => 4),
    Observable.Timer(TimeSpan.FromTicks(60), s).Select(_ => 6));

var merged = Observable.Merge(a, b);

merged.Subscribe(v => Console.WriteLine(v));

s.Start();
