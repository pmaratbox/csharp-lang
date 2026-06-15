using System.Text.Json;

var opts = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };

var person = new Person(30, "alice");
string json = JsonSerializer.Serialize(person, opts);
var back = JsonSerializer.Deserialize<Person>(json, opts)!;
Console.WriteLine(back.Name);

record Person(int Age, string Name);
