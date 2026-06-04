var path = Path.Combine(Directory.GetCurrentDirectory(), "tofile.txt");
File.WriteAllText(path, "a" + Environment.NewLine);
File.AppendAllText(path, "b" + Environment.NewLine);

var lines = File.ReadAllLines(path);
File.Delete(path);

Console.WriteLine(string.Join(" ", lines));
