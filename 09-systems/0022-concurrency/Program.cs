Task<int> a = Task.Run(() => 1);
Task<int> b = Task.Run(() => 2);
int[] results = await Task.WhenAll(a, b);
Console.WriteLine($"sum: {results[0] + results[1]}");
