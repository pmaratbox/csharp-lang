string result = string.Join("-", "a,b,c".Split(',').Select(p => p.ToUpperInvariant()));
Console.WriteLine(result);
