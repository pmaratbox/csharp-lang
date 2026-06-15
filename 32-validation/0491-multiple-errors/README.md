# 0491 — Multiple errors

Validate a model with the FluentValidation library, collecting every failing field instead of stopping at the first error. The `MultipleErrorsValidator` declares `RuleFor(x => x.Name).MinimumLength(3)` and `RuleFor(x => x.Age).InclusiveBetween(0, 120)`, and sets `CascadeMode.Continue` so the validator reports all violations. The input `{ name = "al", age = 200 }` breaks both rules; the output is the failing field name(s) taken from `result.Errors` (lowercased, deduped and sorted), or `ok` if validation passes.

## Run

    dotnet run
