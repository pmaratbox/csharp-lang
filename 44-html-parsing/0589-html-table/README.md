# 0589 — Extract table cells

Uses the AngleSharp library to parse a fixed HTML table and query it with the CSS type selector `td`. `QuerySelectorAll("td")` returns every cell in document order (row-major), and each cell's `TextContent` is joined with commas to produce `r1c1,r1c2,r2c1,r2c2`.

## Run

    dotnet run
