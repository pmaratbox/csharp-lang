using Tomlyn;
using Tomlyn.Model;

var doc = "[server]\nhost = \"localhost\"\nport = 8080\n";

var model = Toml.ToModel(doc);
var server = (TomlTable)model["server"];

Console.WriteLine($"host={server["host"]} port={server["port"]}");
