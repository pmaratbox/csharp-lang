using System.Text.Json;
using System.Text.Json.Serialization;

var opts = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
Console.WriteLine(JsonSerializer.Serialize(new Person("alice"), opts));

record Person([property: JsonPropertyName("full_name")] string FullName);
