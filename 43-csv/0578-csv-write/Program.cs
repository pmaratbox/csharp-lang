using System.Globalization;
using CsvHelper;

// Write two rows with CsvHelper's CsvWriter into an in-memory buffer.
var sb = new StringWriter();
using (var w = new CsvWriter(sb, CultureInfo.InvariantCulture))
{
    foreach (var f in new[] { "name", "age" }) w.WriteField(f);
    w.NextRecord();
    foreach (var f in new[] { "Alice", "30" }) w.WriteField(f);
    w.NextRecord();
}

// CsvWriter emits \r\n line terminators; normalize to \n and drop the trailing newline.
Console.WriteLine(sb.ToString().Replace("\r\n", "\n").TrimEnd('\n'));
