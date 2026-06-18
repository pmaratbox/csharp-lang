using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;

var data = "a;b;c\n1;2;3\n";
var config = new CsvConfiguration(CultureInfo.InvariantCulture) { Delimiter = ";" };
using var r = new CsvReader(new StringReader(data), config);
var rows = new List<string[]>();
while (r.Read()) rows.Add(Enumerable.Range(0, r.Parser.Count).Select(i => r.GetField(i)!).ToArray());
Console.WriteLine(string.Join(",", rows[1]));   // 1,2,3
