# 0588 — Nested elements

This lesson uses the **AngleSharp** library to parse a fixed HTML document and query it with the descendant CSS selector `.content p`. `QuerySelectorAll(".content p")` returns the two `<p>` elements nested inside the `.content` div; each element's `TextContent` is taken and the texts are joined with commas to print `first,second`.

## Run

    dotnet run
