var ini = "[s]\nk=v";
var section = "";
foreach (var raw in ini.Split('\n'))
{
    var line = raw.Trim();
    if (line.Length == 0) continue;
    if (line.StartsWith('[') && line.EndsWith(']'))
        section = line[1..^1];
    else
    {
        var idx = line.IndexOf('=');
        var key = line[..idx];
        var value = line[(idx + 1)..];
        Console.WriteLine($"{section}.{key}={value}");
    }
}
