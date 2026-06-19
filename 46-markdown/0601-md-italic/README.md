# 0601 — Italic

Uses the [Markdig](https://github.com/xoofx/markdig) library to render Markdown emphasis (`*italic*`) to HTML via `Markdown.ToHtml`. The renderer wraps the text in a `<p>` containing an `<em>` element and appends a trailing newline, so we strip it with `TrimEnd('\n')` before printing.

## Run

    dotnet run
