# 0593 — Nested element text

This lesson uses the **System.Xml.Linq** library (`XDocument`, part of the .NET standard library) to parse a fixed catalog document. After parsing, it takes the first `<book>` from `d.Root.Elements("book")`, reaches into its nested `<price>` child with `Element("price")`, and prints that element's `.Value` text to print `30`.

## Run

    dotnet run
