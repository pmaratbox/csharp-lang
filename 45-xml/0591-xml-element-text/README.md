# 0591 — Element text

This lesson uses the **System.Xml.Linq** library (`XDocument`, part of the .NET standard library) to parse a fixed catalog document. `XDocument.Parse` builds the tree, `d.Root!.Elements("book")` yields the `<book>` elements, and `books[0].Element("title")!.Value` reads the text of the first book's `<title>` element to print `Go`.

## Run

    dotnet run
