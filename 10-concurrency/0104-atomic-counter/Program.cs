var counter = 0;
var threads = new List<Thread>();

for (var i = 0; i < 10; i++)
{
    var t = new Thread(() =>
    {
        for (var j = 0; j < 100; j++)
            Interlocked.Increment(ref counter);
    });
    t.Start();
    threads.Add(t);
}

foreach (var t in threads)
    t.Join();

Console.WriteLine(counter);
