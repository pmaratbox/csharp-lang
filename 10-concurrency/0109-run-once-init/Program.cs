var initCount = 0;

var lazy = new Lazy<int>(() =>
{
    Interlocked.Increment(ref initCount);
    return 42;
}, LazyThreadSafetyMode.ExecutionAndPublication);

var threads = new List<Thread>();
for (var i = 0; i < 10; i++)
{
    var t = new Thread(() => { _ = lazy.Value; });
    t.Start();
    threads.Add(t);
}

foreach (var t in threads)
    t.Join();

Console.WriteLine($"init count: {initCount}");
