using System.Globalization;

var time = new TimeOnly(10, 45);
var result = time.AddMinutes(90);
Console.WriteLine(result.ToString("HH:mm", CultureInfo.InvariantCulture));
