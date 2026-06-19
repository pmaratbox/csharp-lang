# 0604 — Unordered list

Uses the [Markdig](https://github.com/xoofx/markdig) library to render a Markdown unordered list (`- a\n- b`) to HTML via `Markdown.ToHtml`. The renderer appends a trailing newline, so we strip it with `TrimEnd('\n')` before printing the resulting `<ul>` with its `<li>` items.

## Run

    dotnet run
