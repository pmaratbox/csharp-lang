var path = Path.Combine(Directory.GetCurrentDirectory(), "filelines.txt");
File.WriteAllLines(path, new[] { "one", "two", "three" });

var count = File.ReadAllLines(path).Count(line => line.Length > 0);
File.Delete(path);

Console.WriteLine($"lines: {count}");
