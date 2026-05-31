Person p = new("Ada", 36);

Console.WriteLine($"name: {p.Name}");
Console.WriteLine($"age: {p.Age}");

record Person(string Name, int Age);
