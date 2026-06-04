int result = await Task.FromResult(5)
    .ContinueWith(t => t.Result * 2)
    .ContinueWith(t => t.Result + 1);

Console.WriteLine(result);
