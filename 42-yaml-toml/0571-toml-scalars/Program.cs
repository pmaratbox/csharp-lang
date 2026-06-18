using Tomlyn;

var model = Toml.ToModel("title = \"demo\"\nversion = 2\n");
Console.WriteLine($"{model["title"]} {model["version"]}");
