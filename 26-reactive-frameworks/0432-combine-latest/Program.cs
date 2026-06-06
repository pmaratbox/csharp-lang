using System.Reactive.Linq;
using Microsoft.Reactive.Testing;

var scheduler = new TestScheduler();

// A emits 1@10, 2@30
var a = Observable.Merge(
    Observable.Timer(TimeSpan.FromTicks(10), scheduler).Select(_ => 1),
    Observable.Timer(TimeSpan.FromTicks(30), scheduler).Select(_ => 2));

// B emits 10@20
var b = Observable.Timer(TimeSpan.FromTicks(20), scheduler).Select(_ => 10);

a.CombineLatest(b, (x, y) => $"({x}, {y})")
    .Subscribe(Console.WriteLine);

scheduler.Start();
