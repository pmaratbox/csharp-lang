var text = "a b\nc";
var words = text.Split((char[]?)null, StringSplitOptions.RemoveEmptyEntries).Length;
var lines = text.Split('\n').Length;
var chars = text.Length;
Console.WriteLine($"{words} {lines} {chars}");
