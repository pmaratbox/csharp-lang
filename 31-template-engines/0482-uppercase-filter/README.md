# 0482 — Uppercase filter

Render a template with the Scriban template engine, applying its built-in `string.upcase` filter. The template `{{ name | string.upcase }}` pipes the model value through Scriban's uppercase string function; `Template.Parse` compiles the source and `Render` evaluates it against the fixed model `{ name = "alice" }`, producing `ALICE`.

## Run

    dotnet run
