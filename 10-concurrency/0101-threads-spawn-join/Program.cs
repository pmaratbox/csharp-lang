var threads = new List<Thread>();
for (var i = 0; i < 3; i++)
{
    var t = new Thread(() => { _ = 1 + 1; });
    t.Start();
    threads.Add(t);
}

foreach (var t in threads)
    t.Join();

Console.WriteLine($"done: {threads.Count}");
