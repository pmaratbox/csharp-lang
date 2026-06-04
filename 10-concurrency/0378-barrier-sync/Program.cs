using System.Threading;

int count = 0;
using var barrier = new Barrier(3, _ => Interlocked.Exchange(ref count, 3));

var threads = new Thread[3];
for (int i = 0; i < threads.Length; i++)
{
    threads[i] = new Thread(() => barrier.SignalAndWait());
    threads[i].Start();
}
foreach (var t in threads) t.Join();

Console.WriteLine($"all reached: {count}");
