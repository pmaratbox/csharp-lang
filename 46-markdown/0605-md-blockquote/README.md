# 0605 — Blockquote

Uses the [Markdig](https://github.com/xoofx/markdig) library to render a Markdown blockquote (`> quote`) to HTML via `Markdown.ToHtml`. The renderer appends a trailing newline, so we strip it with `TrimEnd('\n')` before printing the resulting `<blockquote>` wrapping a `<p>` paragraph.

## Run

    dotnet run
