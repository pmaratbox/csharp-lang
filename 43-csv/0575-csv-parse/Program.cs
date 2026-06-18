using System.Globalization;
using CsvHelper;

var data = "name,age,city\nAlice,30,Paris\nBob,25,London\nCarol,35,Berlin\n";

using var r = new CsvReader(new StringReader(data), CultureInfo.InvariantCulture);

var rows = new List<string[]>();
while (r.Read())
    rows.Add(Enumerable.Range(0, r.Parser.Count).Select(i => r.GetField(i)!).ToArray());

// Skip the header row; join the first column (name) of each data row.
Console.WriteLine(string.Join(",", rows.Skip(1).Select(x => x[0])));
