using YamlDotNet.Serialization;

var doc = "name: Alice\nrole: admin\nage: 30\n";

var de = new DeserializerBuilder().Build();
var d = de.Deserialize<Dictionary<string, object>>(doc);

Console.WriteLine($"{d["name"]} {d["role"]} {d["age"]}");
