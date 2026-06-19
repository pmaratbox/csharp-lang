var chunks = Enumerable.Range(1, 6).Chunk(2);
Console.WriteLine(string.Join("|", chunks.Select(c => string.Join(",", c))));
