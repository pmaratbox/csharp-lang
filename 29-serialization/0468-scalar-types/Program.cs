using System.Text.Json;

var opts = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
Console.WriteLine(JsonSerializer.Serialize(new Sample(true, 5, "x"), opts));

record Sample(bool Active, int Count, string Label);
