using System.Threading;

int shared = 0;

void Increment()
{
    while (true)
    {
        int current = Volatile.Read(ref shared);
        if (Interlocked.CompareExchange(ref shared, current + 1, current) == current)
            return;
    }
}

var threads = new Thread[4];
for (int i = 0; i < threads.Length; i++)
{
    threads[i] = new Thread(() => { for (int j = 0; j < 25; j++) Increment(); });
    threads[i].Start();
}
foreach (var t in threads) t.Join();

Console.WriteLine(shared);
