using System.Globalization;

var input = "{\"x\":1,\"y\":2}";
var body = input.Trim('{', '}');
var parts = new List<string>();
foreach (var pair in body.Split(','))
{
    var kv = pair.Split(':');
    var key = kv[0].Trim().Trim('"');
    var value = int.Parse(kv[1].Trim(), CultureInfo.InvariantCulture);
    parts.Add($"{key}={value.ToString(CultureInfo.InvariantCulture)}");
}
Console.WriteLine(string.Join(' ', parts));
