# 0492 — Custom rule

Uses FluentValidation's `AbstractValidator<Model>` with a custom rule via `Must(...)` to require that `Password` contains at least one digit. The input `{password: abcdef}` has no digit, so the custom predicate returns `false` and `Validate` reports the failure. The output is the sorted, lowercased failing field name(s) extracted from the validator's error result, or `ok` when validation passes.

## Run

    dotnet run
