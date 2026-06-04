var first = Task.Run(() => 10);
var second = Task.Run(() => 20);

var results = await Task.WhenAll(first, second);

Console.WriteLine(results[0] + results[1]);
