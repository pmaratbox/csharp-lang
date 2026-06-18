using System.Globalization;
using CsvHelper;

var data = "name,age,city\nAlice,30,Paris\nBob,25,London\nCarol,35,Berlin\n";

using var reader = new CsvReader(new StringReader(data), CultureInfo.InvariantCulture);

var rows = new List<string[]>();
while (reader.Read())
    rows.Add(Enumerable.Range(0, reader.Parser.Count).Select(i => reader.GetField(i)!).ToArray());

// Skip the header, keep data rows where age > 28, collect their names.
var names = rows
    .Skip(1)
    .Where(r => int.Parse(r[1], CultureInfo.InvariantCulture) > 28)
    .Select(r => r[0]);

Console.WriteLine(string.Join(",", names));
