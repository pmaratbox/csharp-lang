# 0484 — List length

Render the length of a list with the Scriban template engine. The template `{{ items.size }}` uses Scriban's array `.size` member, which reports the element count of the array; `Template.Parse` compiles the source and `Render` evaluates it against the fixed model `{ items = [1, 2, 3] }`, producing `3`.

## Run

    dotnet run
