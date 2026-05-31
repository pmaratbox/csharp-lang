# 0010 — Structs

Define a `Person` type with a `Name` and an `Age`, create one ("Ada", 36), and
print each field. A positional `record` (C# 9+) is a concise immutable data
carrier: it auto-generates the constructor, init-only properties, value
equality, and a `ToString`. `new("Ada", 36)` is a target-typed `new`, inferring
the type from the declaration. Fields are read with dot access (`p.Name`).

## Run

    dotnet run
