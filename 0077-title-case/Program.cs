var text = "hello world";
var result = string.Join(" ", text.Split(' ').Select(w => char.ToUpper(w[0]) + w.Substring(1)));
Console.WriteLine(result);
