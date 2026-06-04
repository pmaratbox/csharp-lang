var inner = new Exception("inner");
var outer = new Exception("outer", inner);

Console.WriteLine($"{outer.Message}: {outer.InnerException!.Message}");
