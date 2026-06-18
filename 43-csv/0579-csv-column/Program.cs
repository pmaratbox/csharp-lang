using System.Globalization;
using CsvHelper;

var data = "name,age,city\nAlice,30,Paris\nBob,25,London\nCarol,35,Berlin\n";

using var reader = new CsvReader(new StringReader(data), CultureInfo.InvariantCulture);
reader.Read();
reader.ReadHeader();
int ageIndex = Array.IndexOf(reader.HeaderRecord!, "age");

var ages = new List<string>();
while (reader.Read())
    ages.Add(reader.GetField(ageIndex)!);

Console.WriteLine(string.Join(",", ages));
