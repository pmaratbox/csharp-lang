# 0477 — Variable substitution

Render a template with the Scriban template engine, substituting a single variable into the output. The template `Hello {{ name }}` uses Scriban's `{{ name }}` interpolation syntax; `Template.Parse` compiles the source and `Render` evaluates it against the fixed model `{ name = "alice" }`, producing `Hello alice`.

## Run

    dotnet run
