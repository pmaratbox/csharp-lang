using System.Globalization;
using CsvHelper;

var data = "name,age,city\nAlice,30,Paris\nBob,25,London\nCarol,35,Berlin\n";

using var r = new CsvReader(new StringReader(data), CultureInfo.InvariantCulture);

var rows = new List<string[]>();
while (r.Read())
    rows.Add(Enumerable.Range(0, r.Parser.Count).Select(i => r.GetField(i)!).ToArray());

// Header maps column names to indexes; find the `age` column.
var header = rows[0];
var ageIdx = Array.IndexOf(header, "age");

// Parse the `age` field of each data row to int and sum them.
var sum = rows.Skip(1).Sum(x => int.Parse(x[ageIdx], CultureInfo.InvariantCulture));

Console.WriteLine(sum);
