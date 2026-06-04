using System.Threading.Channels;

var channel = Channel.CreateBounded<int>(2);

var producer = Task.Run(async () =>
{
    for (var i = 1; i <= 5; i++)
        await channel.Writer.WriteAsync(i);
    channel.Writer.Complete();
});

var sum = 0;
await foreach (var value in channel.Reader.ReadAllAsync())
    sum += value;

await producer;

Console.WriteLine(sum);
