using System.Globalization;
using CsvHelper;

var data = "name,note\nAlice,\"hello, world\"\n";

using var reader = new CsvReader(new StringReader(data), CultureInfo.InvariantCulture);
reader.Read(); // header row
reader.Read(); // data row

// The library unquotes the field, so the embedded comma is preserved.
var note = reader.GetField(1)!;

Console.WriteLine(note);
