string Greet(string name, string greeting = "Hello") => $"{greeting}, {name}";

Console.WriteLine(Greet("Ada"));
Console.WriteLine(Greet("Ada", greeting: "Hi"));
