# 0603 — Inline code

Uses the [Markdig](https://github.com/xoofx/markdig) library to render a Markdown inline code span (`` `code` ``) to HTML via `Markdown.ToHtml`. The renderer appends a trailing newline, so we strip it with `TrimEnd('\n')` before printing the resulting `<p>` wrapping a `<code>` element.

## Run

    dotnet run
