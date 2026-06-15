# 0478 — Conditional

Render based on a condition using the Scriban template engine. The template uses Scriban's `{{ if ... }} ... {{ else }} ... {{ end }}` block to branch on the `logged_in` field. With the fixed data `{ logged_in = true }`, the `if` branch is taken and the engine renders `welcome` (the `else` branch would render `guest`).

## Run

    dotnet run
