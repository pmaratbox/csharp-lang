var json = "[1,2,3]";
var inner = json.Trim()[1..^1];
var sum = inner.Split(',').Sum(int.Parse);
Console.WriteLine(sum);
