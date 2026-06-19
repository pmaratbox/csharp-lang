# 0602 — Link

Uses the [Markdig](https://github.com/xoofx/markdig) library to render a Markdown inline link (`[text](http://x.com)`) to HTML via `Markdown.ToHtml`. The renderer appends a trailing newline, so we strip it with `TrimEnd('\n')` before printing the resulting `<p>` wrapping an `<a>` anchor element.

## Run

    dotnet run
