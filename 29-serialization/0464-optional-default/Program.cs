using System.Text.Json;

var opts = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };

// The "age" field is absent from the JSON; it falls back to the record's default value.
var person = JsonSerializer.Deserialize<Person>("{\"name\":\"alice\"}", opts)!;

Console.WriteLine($"{person.Name} {person.Age}");

record Person(int Age = 0, string Name = "");
