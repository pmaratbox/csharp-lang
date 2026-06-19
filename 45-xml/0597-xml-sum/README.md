# 0597 — Sum numeric children

This lesson uses the **System.Xml.Linq** library (`XDocument`, part of the .NET standard library) to parse a fixed catalog document. After parsing, it walks each `<book>` from `d.Root.Elements("book")`, reads the nested `<price>` child's `.Value`, parses it with `int.Parse`, and sums the prices (30 + 45) to print `75`.

## Run

    dotnet run
