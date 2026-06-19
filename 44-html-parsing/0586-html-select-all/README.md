# 0586 — Select all matching

Uses the AngleSharp library to parse a fixed HTML document and query it with the CSS class selector `.item` via `QuerySelectorAll`. Each matching `<li>` element's `TextContent` is extracted and the values are joined with commas to print `apple,banana,cherry`.

## Run

    dotnet run
