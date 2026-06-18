using YamlDotNet.Serialization;

// Build a map and serialize it to sorted block-style YAML with YamlDotNet.
// A SortedDictionary keeps keys ordered (age, city, name), and the default
// serializer emits block style with no flow braces or quotes on simple scalars.
var m = new SortedDictionary<string, object>
{
    ["name"] = "Alice",
    ["age"] = 30,
    ["city"] = "Paris",
};

var serializer = new SerializerBuilder().Build();
Console.Write(serializer.Serialize(m));
