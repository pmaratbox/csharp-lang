using System.Text.Json;

var opts = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
var people = new List<Person> { new Person(30, "alice"), new Person(25, "bob") };
Console.WriteLine(JsonSerializer.Serialize(people, opts));

record Person(int Age, string Name);
