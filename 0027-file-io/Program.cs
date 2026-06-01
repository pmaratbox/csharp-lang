string path = "greeting.txt";
File.WriteAllText(path, "hello, file");
string content = File.ReadAllText(path);
File.Delete(path);
Console.WriteLine($"read: {content}");
