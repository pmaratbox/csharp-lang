# 0598 — Filter by attribute

Uses the System.Xml.Linq library (part of the .NET standard library) to parse a fixed XML catalog document with `XDocument.Parse`. It selects every `<book>` element, keeps only those whose `lang` attribute equals `en` (just `b1`), reads each kept book's `<title>` text, and joins the results with commas to print `Go`.

## Run

    dotnet run
