# 0599 — Heading

Uses the [Markdig](https://github.com/xoofx/markdig) library to render a Markdown ATX heading (`# Hello`) to HTML via `Markdown.ToHtml`. The renderer appends a trailing newline, so we strip it with `TrimEnd('\n')` before printing the resulting `<h1>` element.

## Run

    dotnet run
