# 0480 — Nested access

Render a template with the Scriban template engine, reaching into a nested field of the model. The template `{{ user.name }}` uses Scriban's dot member-access syntax to walk from the `user` object to its `name` property; `Template.Parse` compiles the source and `Render` evaluates it against the fixed model `{ user = new { name = "alice" } }`, producing `alice`.

## Run

    dotnet run
