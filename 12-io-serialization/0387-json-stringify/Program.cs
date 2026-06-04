using System.Globalization;

var name = "Ada";
var age = 36;
var json = $"{{\"name\":\"{name}\",\"age\":{age.ToString(CultureInfo.InvariantCulture)}}}";
Console.WriteLine(json);
