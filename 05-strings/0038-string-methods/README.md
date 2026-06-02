# 0038 — String Methods

Split `"a,b,c"` on commas, upper-case each part, and join them with `-`, printing `A-B-C`. `Split(',')` returns a `string[]`, LINQ's `Select` maps `ToUpperInvariant()`, and `string.Join("-", ...)` recombines. `ToUpperInvariant` avoids culture-specific casing surprises (such as the Turkish dotless i).

## Run

    dotnet run
