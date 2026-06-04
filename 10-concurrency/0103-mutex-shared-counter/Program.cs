var counter = 0;
var gate = new object();
var threads = new List<Thread>();

for (var i = 0; i < 10; i++)
{
    var t = new Thread(() =>
    {
        for (var j = 0; j < 100; j++)
        {
            lock (gate)
                counter++;
        }
    });
    t.Start();
    threads.Add(t);
}

foreach (var t in threads)
    t.Join();

Console.WriteLine(counter);
