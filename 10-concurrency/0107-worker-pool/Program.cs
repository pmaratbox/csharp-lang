var inputs = new[] { 1, 2, 3, 4 };

var tasks = inputs.Select(n => Task.Run(() => n * n));
var results = await Task.WhenAll(tasks);

Array.Sort(results);

Console.WriteLine(string.Join(" ", results));
