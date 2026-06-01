# 0021 — Mutability & References

Have a function increment a value in place — through a pointer, reference, or mutable holder — so the caller sees it change from `before: 1` to `after: 2`. A `ref` parameter aliases the caller's variable, so `n++` updates the original; the caller also writes `ref` at the call site (`Inc(ref n)`). C# is pass-by-value by default — value types are copied and reference-type *references* are copied — so `ref` is how you mutate a caller's local.

## Run

    dotnet run
