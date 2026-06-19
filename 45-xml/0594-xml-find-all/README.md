# 0594 — Find all elements and collect their text

Uses the System.Xml.Linq library (XDocument, part of the .NET standard library) to parse a fixed catalog document and extract the text of every matching element. `XDocument.Parse` builds the tree, `Root.Elements("book")` yields all `<book>` elements in document order, and `Element("title")!.Value` reads each title; the values are joined with commas to print `Go,Rust`.

## Run

    dotnet run
