# 0118 — Option Map Chaining

Map a function over a present optional (10 -> 12) and an absent one (-> fallback), printing `12 none`. C# models the optional as a nullable `int?`, and a `is int v` pattern maps the value when present or yields `null` (shown as the `none` fallback) when absent.

## Run

    dotnet run
