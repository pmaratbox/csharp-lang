using Tomlyn;
using Tomlyn.Model;

var doc = "[[servers]]\nname = \"alpha\"\n[[servers]]\nname = \"beta\"\n";

var model = Toml.ToModel(doc);
var servers = (TomlTableArray)model["servers"];
Console.WriteLine(string.Join(",", servers.Select(s => (string)s["name"]!)));
