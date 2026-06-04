using System.Text.RegularExpressions;

var vars = new Dictionary<string, string> { ["name"] = "Ada" };
var template = "hi {name}";
var result = Regex.Replace(template, @"\{(\w+)\}", m => vars[m.Groups[1].Value]);
Console.WriteLine(result);
