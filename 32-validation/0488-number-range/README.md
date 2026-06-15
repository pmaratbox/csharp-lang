# 0488 — Number range

Validate a model with the FluentValidation library, enforcing that a numeric field falls within an inclusive range. The validator's `RuleFor(x => x.Age).InclusiveBetween(0, 120)` constraint rejects the input `{ name: "alice", age: 200 }` because `age` exceeds the upper bound. The canonical output is the sorted, lowercased failing field name(s) extracted from `result.Errors` (via each error's `PropertyName`), or `ok` if validation passes.

## Run

    dotnet run
