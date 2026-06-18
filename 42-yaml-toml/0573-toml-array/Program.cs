using Tomlyn;
using Tomlyn.Model;

var model = Toml.ToModel("tags = [\"red\", \"green\", \"blue\"]\n");
var tags = (TomlArray)model["tags"];
Console.WriteLine(string.Join(",", tags.Select(x => (string)x!)));
