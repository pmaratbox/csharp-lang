using YamlDotNet.Serialization;

var de = new DeserializerBuilder().Build();
var doc = de.Deserialize<Dictionary<string, object>>("fruits:\n  - apple\n  - banana\n  - cherry\n");
var fruits = (List<object>)doc["fruits"];
Console.WriteLine(string.Join(",", fruits.Select(f => (string)f)));
