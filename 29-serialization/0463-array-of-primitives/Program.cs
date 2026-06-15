using System.Text.Json;

var numbers = new List<int> { 1, 2, 3 };
Console.WriteLine(JsonSerializer.Serialize(numbers));
