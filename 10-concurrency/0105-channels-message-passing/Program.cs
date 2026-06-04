using System.Threading.Channels;

var channel = Channel.CreateUnbounded<int>();

var producer = Task.Run(async () =>
{
    for (var i = 1; i <= 3; i++)
        await channel.Writer.WriteAsync(i);
    channel.Writer.Complete();
});

var received = new List<int>();
await foreach (var value in channel.Reader.ReadAllAsync())
    received.Add(value);

await producer;

Console.WriteLine(string.Join(" ", received));
