# 0664 — Nested dependency chain

Uses [Microsoft.Extensions.DependencyInjection](https://learn.microsoft.com/dotnet/core/extensions/dependency-injection) to register a 3-level service graph: `A`, `B` (depends on `A`), and `C` (depends on `B`). The container resolves `C`, recursively constructing `B` and `A` and injecting each one. Calling `C.V()` walks the chain — `A.V()` returns `a`, `B.V()` appends `b`, and `C.V()` appends `c` — printing `abc`.

## Run

    dotnet run
