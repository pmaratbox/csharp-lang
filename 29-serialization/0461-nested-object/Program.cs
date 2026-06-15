using System.Text.Json;

var opts = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
var person = new Person(new Address("oslo", 1000), "alice");
Console.WriteLine(JsonSerializer.Serialize(person, opts));

record Person(Address Address, string Name);
record Address(string City, int Zip);
