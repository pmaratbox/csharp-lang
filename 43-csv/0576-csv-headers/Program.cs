using System.Globalization;
using CsvHelper;

var data = "name,age,city\nAlice,30,Paris\nBob,25,London\nCarol,35,Berlin\n";

using var reader = new CsvReader(new StringReader(data), CultureInfo.InvariantCulture);
reader.Read();
var header = Enumerable.Range(0, reader.Parser.Count)
    .Select(i => reader.GetField(i)!)
    .ToArray();

Console.WriteLine(string.Join("|", header));
