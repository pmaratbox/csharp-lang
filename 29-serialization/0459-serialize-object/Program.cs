using System.Text.Json;

var opts = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
Console.WriteLine(JsonSerializer.Serialize(new Person(30, "alice"), opts));

record Person(int Age, string Name);
