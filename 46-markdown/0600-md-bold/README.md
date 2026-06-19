# 0600 — Bold

Uses the [Markdig](https://github.com/xoofx/markdig) library to render Markdown bold (strong emphasis, `**bold**`) to HTML via `Markdown.ToHtml`. The renderer appends a trailing newline, so we strip it with `TrimEnd('\n')` before printing the resulting `<p><strong>bold</strong></p>`.

## Run

    dotnet run
