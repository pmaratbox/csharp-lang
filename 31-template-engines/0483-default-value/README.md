# 0483 — Default value

Provide a default for a missing value. Uses the Scriban template engine: the template `{{ name ?? "anonymous" }}` relies on Scriban's null-coalescing operator `??`, which yields the right-hand value when the left side is missing or undefined. The data object has no `name` field, so the engine substitutes the fallback and renders `anonymous`.

## Run

    dotnet run
