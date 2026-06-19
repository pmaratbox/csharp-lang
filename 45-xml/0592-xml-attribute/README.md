# 0592 — Read an element's attribute

Uses the System.Xml.Linq library (XDocument, part of the .NET standard library) to parse a fixed catalog document and extract an attribute value. `XDocument.Parse` builds the tree, `Root.Elements("book")` yields the book elements in document order, and `Attribute("id")!.Value` reads the `id` attribute of the first `<book>` to print `b1`.

## Run

    dotnet run
