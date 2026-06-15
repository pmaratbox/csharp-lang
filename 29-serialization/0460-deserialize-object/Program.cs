using System.Text.Json;

var opts = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
var json = "{\"age\":30,\"name\":\"alice\"}";
var person = JsonSerializer.Deserialize<Person>(json, opts)!;
Console.WriteLine($"{person.Name} {person.Age}");

record Person(int Age, string Name);
