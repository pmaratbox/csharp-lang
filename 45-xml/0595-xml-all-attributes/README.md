# 0595 — All attributes

Uses the System.Xml.Linq library (XDocument, part of the .NET standard library) to parse a fixed catalog document and collect an attribute from every matching element. `XDocument.Parse` builds the tree, `Root.Elements("book")` yields the book elements in document order, and `Attribute("id")!.Value` reads each `id`; joining them with commas prints `b1,b2`.

## Run

    dotnet run
