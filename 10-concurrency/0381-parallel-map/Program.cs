int[] input = { 1, 2, 3, 4 };

int[] results = await Task.WhenAll(
    input.Select(n => Task.Run(() => n * n)));

Console.WriteLine(string.Join(" ", results));
