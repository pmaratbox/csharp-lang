# 0596 — Count the book elements

Uses the System.Xml.Linq library (part of the .NET standard library) to parse a fixed XML catalog document with `XDocument.Parse`. It selects every `<book>` child of the root with `d.Root!.Elements("book")` and prints the count `2`.

## Run

    dotnet run
