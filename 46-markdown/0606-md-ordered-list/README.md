# 0606 — Ordered list

Uses the Markdig library to render a Markdown ordered list (`1. a` / `2. b`) to HTML. `Markdown.ToHtml` produces an `<ol>` with `<li>` items; the trailing newline appended by the renderer is stripped before printing.

## Run

    dotnet run
