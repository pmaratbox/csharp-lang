# 0485 — Valid input

Uses FluentValidation's `AbstractValidator<Model>` to enforce `Name` (`MinimumLength(3)`) and `Age` (`InclusiveBetween(0, 120)`). The valid input `{name: alice, age: 30}` satisfies both rules, so `Validate` returns no errors. The output is the sorted, lowercased failing field name(s) extracted from the validator's error result, or `ok` when validation passes.

## Run

    dotnet run
