var rows = new[] { ("a", "1"), ("bb", "22") };
int width = rows.Max(r => r.Item1.Length);

foreach (var (c1, c2) in rows)
    Console.WriteLine($"{c1.PadRight(width)} | {c2}");
